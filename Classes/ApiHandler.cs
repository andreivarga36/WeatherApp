using Newtonsoft.Json;
using WeatherApp.Interfaces;

namespace WeatherApp.Classes
{
    public class ApiHandler : IApiHandler
    {
        public WeatherInfo DeserializeObject(string responseContent)
        {
            if (string.IsNullOrEmpty(responseContent))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<WeatherInfo>(responseContent);
        }
    }
}
