using WeatherApp.Classes;

namespace WeatherAppFacts.TestClasses
{
    public class ApiHandlerFacts
    {
        [Fact]
        public void DeserializeObject_ResponseContentIsValidJson_ShouldReturnExpectedResult()
        {
            string responseContent = "{ \"coord\": {\r\n    \"lon\": 10.99,\r\n    \"lat\": 44.34\r\n  }, }";
            ApiHandler apiHandler = new ();

            WeatherInfo weatherInfo = apiHandler.DeserializeObject(responseContent);

            Assert.NotNull(weatherInfo);
        }

        [Fact]
        public void DeserializeObject_ResponseContentIsNotValidJson_ShouldReturnExpectedResult()
        {
            string responseContent = "{ \"coord\": {\r\n    \"lon\": 10.99,\r\n    \"lat\": 44.34\r\n}";
            ApiHandler apiHandler = new ();

            Assert.Throws<InvalidOperationException>(() => apiHandler.DeserializeObject(responseContent));
        }


        [Fact]
        public void DeserializeObject_ResponseContentIsEmpty_ShouldReturnExpectedResult()
        {
            string responseContent = "";
            ApiHandler apiHandler = new();

            WeatherInfo weatherInfo = apiHandler.DeserializeObject(responseContent);

            Assert.Null(weatherInfo);
        }


        [Fact]
        public void DeserializeObject_ResponseContentIsNull_ShouldReturnExpectedResult()
        {
            string? responseContent = null;
            ApiHandler apiHandler = new ();

            Assert.Throws<InvalidOperationException>(() => apiHandler.DeserializeObject(responseContent));
        }
    }
}
