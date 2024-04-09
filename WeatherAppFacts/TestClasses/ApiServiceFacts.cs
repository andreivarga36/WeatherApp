using Moq;
using Moq.Protected;
using System.Net;
using WeatherApp.Classes;

namespace WeatherAppFacts.TestClasses
{
    public class ApiServiceFacts
    {
        [Fact]
        public async Task RetrieveWeatherInformationAsync_HttpStatusCodeIsOk_ShouldReturnExpectedResult()
        {
            string city = "London";
            string apiKey = "fakeApiKey";

            var mockHttpHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            mockHttpHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("{\"temperature\": 20}")
                });

            var httpClient = new HttpClient(mockHttpHandler.Object);
            var apiService = new ApiService(httpClient);

            var weatherInfo = await apiService.RetrieveWeatherInformationAsync(city, apiKey);

            Assert.NotNull(weatherInfo);
            Assert.Contains("temperature", weatherInfo);
        }

        [Fact]
        public async Task RetrieveWeatherInformationAsync_CityIsNotFound_ShouldThrowException()
        {
            var city = "NonexistentCity";
            var apiKey = "fakeApiKey";

            var mockHttpHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            mockHttpHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.NotFound,
                });

            var httpClient = new HttpClient(mockHttpHandler.Object);
            var apiService = new ApiService(httpClient);

            await Assert.ThrowsAsync<InvalidOperationException>(() => apiService.RetrieveWeatherInformationAsync(city, apiKey));

        }

        [Fact]
        public async Task RetrieveWeatherInformationAsync_InternalServerError_ShouldThrowException()
        {
            var city = "Bucharest";
            var apiKey = "fakeApiKey";

            var mockHttpHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            mockHttpHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.InternalServerError
                });

            var httpClient = new HttpClient(mockHttpHandler.Object);
            var apiService = new ApiService(httpClient);

            await Assert.ThrowsAsync<InvalidOperationException>(() => apiService.RetrieveWeatherInformationAsync(city, apiKey));
        }

        [Fact]
        public async Task RetrieveWeatherInformationAsync_NetworkUnavailable_ShouldThrowException()
        {
            string city = "Madrid";
            string apiKey = "fakeApiKey";

            var mockHttpHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            mockHttpHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ThrowsAsync(new HttpRequestException());

            var httpClient = new HttpClient(mockHttpHandler.Object);
            var apiService = new ApiService(httpClient);

            await Assert.ThrowsAsync<InvalidOperationException>(() => apiService.RetrieveWeatherInformationAsync(city, apiKey));
        }

        [Fact]
        public async Task RetrieveWeatherInformationAsync_UnexpectedJsonResponse_ShouldReturnExpectedResult()
        {
            string city = "Barcelona";
            string apiKey = "fakeApiKey";
            string expectedResponse = "{\"temperature\": 20}";

            var mockHttpHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            mockHttpHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("{\"invalid_field\": 20}")
                });

            var httpClient = new HttpClient(mockHttpHandler.Object);
            var apiService = new ApiService(httpClient);

            string weatherInfo = await apiService.RetrieveWeatherInformationAsync(city, apiKey);

            Assert.NotEqual(weatherInfo, expectedResponse);
            Assert.Contains("invalid_field", weatherInfo);
        }

        [Fact]
        public async Task RetrieveWeatherInformationAsync_NullResponse_ShouldThrowException()
        {
            string city = "London";
            string apiKey = "fakeApiKey";

            var mockHttpHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            _ = mockHttpHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(() => null);

            var httpClient = new HttpClient(mockHttpHandler.Object);
            var apiService = new ApiService(httpClient);

            await Assert.ThrowsAsync<InvalidOperationException>(() => apiService.RetrieveWeatherInformationAsync(city, apiKey));
        }

        [Fact]
        public async Task RetrieveWeatherInformationAsync_RequestLimitExceeded_ShouldThrowException()
        {
            string city = "Paris";
            string apiKey = "fakeApiKey";

            var mockHttpHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            mockHttpHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.TooManyRequests
                });

            var httpClient = new HttpClient(mockHttpHandler.Object);
            var apiService = new ApiService(httpClient);

            await Assert.ThrowsAsync<InvalidOperationException>(() => apiService.RetrieveWeatherInformationAsync(city, apiKey));
        }
    }
}
