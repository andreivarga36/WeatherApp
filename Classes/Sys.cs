using Newtonsoft.Json;

namespace WeatherApp
{
    internal class Sys
    {
        [JsonProperty("sunrise")]
        internal long Sunset { get; set; }

        [JsonProperty("sunset")]
        internal long Sunrise { get; set; }

        [JsonProperty("Country")]
        internal string Country { get; set; }
    }
}
