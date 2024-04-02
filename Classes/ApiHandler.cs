using Newtonsoft.Json;
using System;
using WeatherApp.Interfaces;

namespace WeatherApp.Classes
{
    public class ApiHandler : IApiHandler
    {
        public WeatherInfo DeserializeObject(string responseContent)
        {
            try
            {
                return JsonConvert.DeserializeObject<WeatherInfo>(responseContent);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
