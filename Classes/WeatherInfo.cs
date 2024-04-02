using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApp.Classes
{
    public class WeatherInfo
    {
        [JsonProperty("coord")]
        internal Coord Coord;

        [JsonProperty("weather")]
        internal List<Weather> Weather;

        [JsonProperty("main")]
        internal Main Main;

        [JsonProperty("wind")]
        internal Wind Wind;

        [JsonProperty("sys")]
        internal Sys Sys;

        [JsonProperty("name")]
        internal string City;
    }
}
