using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApp.Classes
{
    public class WeatherInfo
    {
        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("name")]
        public string City { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
