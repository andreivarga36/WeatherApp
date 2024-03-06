using Newtonsoft.Json;

namespace WeatherApp
{
    internal class Sys
    {
        [JsonProperty("sunrise")]
        internal long Sunset { get; }

        [JsonProperty("sunset")]
        internal long Sunrise { get; }
    }
}
