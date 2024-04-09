using System.Threading.Tasks;

namespace WeatherApp.Interfaces
{
    internal interface IApiService
    {
        Task<string> RetrieveWeatherInformationAsync(string city, string apiKey);
    }
}
