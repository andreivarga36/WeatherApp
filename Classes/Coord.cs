using Newtonsoft.Json;

namespace WeatherApp
{
    internal class Coord
    {
        [JsonProperty("lon")]
        internal double Lon { get; set; }

        [JsonProperty("lat")]
        internal double Lat { get; set; }
    }
}
