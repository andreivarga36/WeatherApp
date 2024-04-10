using System.Threading.Tasks;
using WeatherApp.Classes;

namespace WeatherApp.Interfaces
{
    public interface IDataService
    {
        Task<WeatherData> RetrieveWeatherInformationAsync(string city, string apiKey);
    }
}
