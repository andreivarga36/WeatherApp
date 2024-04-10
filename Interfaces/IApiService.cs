using System.Threading.Tasks;
using WeatherApp.Classes;

namespace WeatherApp.Interfaces
{
    public interface IApiService
    {
        Task<string> RetrieveWeatherInformationAsync(string city, string apiKey);

        WeatherData DeserializeObject(string responseContent);

        void DisposeClient();
    }
}
