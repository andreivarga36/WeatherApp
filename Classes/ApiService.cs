using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Interfaces;

namespace WeatherApp.Classes
{
    public class ApiService : IApiService
    {
        private readonly HttpClient httpClient;

        public ApiService()
        {
            httpClient = new HttpClient();
        }

        public ApiService(HttpClient client)
        {
            httpClient = client;
        }

        public WeatherData DeserializeObject(string responseContent)
        {
            if (string.IsNullOrEmpty(responseContent))
            {
                throw new ArgumentException("Response content cannot be null or empty", nameof(responseContent));
            }

            return JsonConvert.DeserializeObject<WeatherData>(responseContent);
        }

        public void DisposeClient()
        {
            httpClient.Dispose();
        }

        public async Task<string> RetrieveWeatherInformationAsync(string city, string apiKey)
        {
            try
            {
                return await HandleWeatherApiResponse(city, apiKey);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }

        private async Task<string> HandleWeatherApiResponse(string city, string apiKey)
        {
            var requestURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            using (HttpResponseMessage response = await httpClient.GetAsync(requestURL))
            {
                if (!response.IsSuccessStatusCode)
                {
                    string errorMessage = $"The API request failed for the city '{city}' with HTTP status code: {response.StatusCode}";
                    throw new InvalidOperationException(errorMessage);
                }

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
