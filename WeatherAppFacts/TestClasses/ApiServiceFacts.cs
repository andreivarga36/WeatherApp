using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using System.Net;
using WeatherApp.Classes;

namespace WeatherAppFacts.TestClasses
{
    public class ApiServiceFacts
    {
        private ApiService apiService = new();

        [Fact]
        public void DeserializeObject_ResponseContentIsValidJson_ShouldReturnExpectedResult()
        {
            string responseContent = "{ \"coord\": {\r\n    \"lon\": 10.99,\r\n    \"lat\": 44.34\r\n  }, }";

            WeatherData weatherInfo = apiService.DeserializeWeatherData(responseContent);

            Assert.Equal(10.99, weatherInfo.Coord.Lon);
            Assert.Equal(44.34, weatherInfo.Coord.Lat);
        }

        [Fact]
        public void DeserializeObject_ResponseContentIsNotValidJson_ShouldReturnExpectedResult()
        {
            string responseContent = "{ \"coord\": {\r\n    \"lon\": 10.99,\r\n    \"lat\": 44.34\r\n}";

            Assert.Throws<JsonSerializationException>(() => apiService.DeserializeWeatherData(responseContent));
        }


        [Fact]
        public void DeserializeObject_ResponseContentIsEmpty_ShouldReturnExpectedResult()
        {
            string responseContent = "";

            Assert.Throws<ArgumentException>(() => apiService.DeserializeWeatherData(responseContent));
        }


        [Fact]
        public void DeserializeObject_ResponseContentIsNull_ShouldReturnExpectedResult()
        {
            string? responseContent = null;

            Assert.Throws<ArgumentException>(() => apiService.DeserializeWeatherData(responseContent));
        }

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
            apiService = new ApiService(httpClient);

            var weatherInfo = await apiService.GetWeatherDataAsync(city, apiKey);

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
            apiService = new ApiService(httpClient);

            await Assert.ThrowsAsync<InvalidOperationException>(() => apiService.GetWeatherDataAsync(city, apiKey));

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
            apiService = new ApiService(httpClient);

            await Assert.ThrowsAsync<InvalidOperationException>(() => apiService.GetWeatherDataAsync(city, apiKey));
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
            apiService = new ApiService(httpClient);

            await Assert.ThrowsAsync<InvalidOperationException>(() => apiService.GetWeatherDataAsync(city, apiKey));
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

            string weatherInfo = await apiService.GetWeatherDataAsync(city, apiKey);

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

            await Assert.ThrowsAsync<InvalidOperationException>(() => apiService.GetWeatherDataAsync(city, apiKey));
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
            apiService = new ApiService(httpClient);

            await Assert.ThrowsAsync<InvalidOperationException>(() => apiService.GetWeatherDataAsync(city, apiKey));
        }

        [Fact]
        public async void DisposeHttpClient_HttpClientIsDisposed_ShouldThrowException()
        {
            string city = "Madrid";
            string apiKey = "validApiKey";

            var mockHttpHandler = new Mock<HttpMessageHandler>();
            mockHttpHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.TooManyRequests
                });

            var httpClient = new HttpClient(mockHttpHandler.Object);

            apiService = new ApiService(httpClient);
            apiService.DisposeHttpClient();

            await Assert.ThrowsAsync<InvalidOperationException>(() => apiService.GetWeatherDataAsync(city, apiKey));
        }
    }
}
