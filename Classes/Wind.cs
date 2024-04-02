using Newtonsoft.Json;

namespace WeatherApp.Classes
{
    internal class Wind
    {
        [JsonProperty("speed")]
        internal double Speed { get; set; }
    }
}
