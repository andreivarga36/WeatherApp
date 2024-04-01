using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp.Interfaces;

namespace WeatherApp.Classes
{
    internal class ApiService : IApiService
    {
        private readonly HttpClient httpClient;

        public ApiService()
        {
            httpClient = new HttpClient();

        }

        public void ReleaseResources()
        {
            httpClient.Dispose();
        }

        public async Task<string> RetrieveWeatherInformationAsync(string city, string apiKey)
        {
            try
            {
                var requestURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
                using (HttpResponseMessage response = await httpClient.GetAsync(requestURL))

                return await response.Content.ReadAsStringAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
    }
}
