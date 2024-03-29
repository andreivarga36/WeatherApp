﻿using Newtonsoft.Json;

namespace WeatherApp
{
    internal class Weather
    {
        [JsonProperty("main")]
        internal string Main { get; set; }

        [JsonProperty("description")]
        internal string Description { get; set; }

        [JsonProperty("icon")]
        internal string Icon { get; set; }
    }
}
