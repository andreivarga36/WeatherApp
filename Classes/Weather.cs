using Newtonsoft.Json;

namespace WeatherApp
{
    internal class Weather
    {
        [JsonProperty("main")]
        internal string Main { get; }

        [JsonProperty("description")]
        internal string Description { get; }

        [JsonProperty("icon")]
        internal string Icon { get; }
    }
}
