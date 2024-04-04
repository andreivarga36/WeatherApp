using Newtonsoft.Json;

namespace WeatherApp.Classes
{
    public class Sys
    {
        [JsonProperty("sunrise")]
        public long Sunrise { get; set; }

        [JsonProperty("sunset")]
        public long Sunset { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
