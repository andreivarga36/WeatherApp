using Newtonsoft.Json;

namespace WeatherApp.Classes
{
    internal class Sys
    {
        [JsonProperty("sunrise")]
        internal long Sunrise { get; set; }

        [JsonProperty("sunset")]
        internal long Sunset { get; set; }

        [JsonProperty("country")]
        internal string Country { get; set; }
    }
}
