using Newtonsoft.Json;

namespace WeatherApp
{
    internal class Wind
    {
        [JsonProperty("speed")]
        internal double Speed { get; }
    }
}
