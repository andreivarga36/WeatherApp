using Newtonsoft.Json;

namespace WeatherApp.Classes
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
    }
}
