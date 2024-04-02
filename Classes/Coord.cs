using Newtonsoft.Json;

namespace WeatherApp.Classes
{
    internal class Coord
    {
        [JsonProperty("lon")]
        internal double Lon { get; set; }

        [JsonProperty("lat")]
        internal double Lat { get; set; }
    }
}
