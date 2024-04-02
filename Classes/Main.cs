﻿using Newtonsoft.Json;

namespace WeatherApp.Classes
{
    internal class Main
    {
        [JsonProperty("temp")]
        internal double Temp { get; set; }

        [JsonProperty("pressure")]
        internal double Pressure { get; set; }

        [JsonProperty("humidity")]
        internal double Humidity { get; set; }
    }
}
