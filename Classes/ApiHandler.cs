using Newtonsoft.Json;
using WeatherApp.Interfaces;

namespace WeatherApp.Classes
{
    internal class ApiHandler : IApiHandler
    {
        public WeatherInfo DeserializeObject(string responseContent)
        {
            return JsonConvert.DeserializeObject<WeatherInfo>(responseContent);
        }
    }
}
