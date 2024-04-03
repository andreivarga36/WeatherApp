using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Interfaces;

namespace WeatherApp.Classes
{
    public class ApiService : IApiService
    {
        private readonly HttpClient httpClient = new HttpClient();

        public async Task<string> RetrieveWeatherInformationAsync(string city, string apiKey)
        {
            try
            {
                var requestURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

                using (HttpResponseMessage response = await httpClient.GetAsync(requestURL))
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }

        public void ReleaseResources()
        {
            httpClient.Dispose();
        }
    }
}
