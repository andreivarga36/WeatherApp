using System.Threading.Tasks;
using WeatherApp.Classes;

namespace WeatherApp.Interfaces
{
    public interface IApiService
    {
        Task<string> GetWeatherDataAsync(string city, string apiKey);

        WeatherData DeserializeWeatherData(string responseContent);

        void DisposeHttpClient();
    }
}
