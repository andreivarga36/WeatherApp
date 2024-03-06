using Newtonsoft.Json;

namespace WeatherApp
{
    internal class Main
    {
        [JsonProperty("temp")]
        internal double Temp {  get; }

        [JsonProperty("pressure")]
        internal double Pressure { get; }

        [JsonProperty("humidity")]
        internal double Humidity { get; }
    }
}
