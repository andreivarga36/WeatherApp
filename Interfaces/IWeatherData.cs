using System.Collections.Generic;
using WeatherApp.Classes;

namespace WeatherApp.Interfaces
{
    public interface IWeatherData
    {
        Coord Coord { get; set; }

        List<Weather> Weather { get; set; }

        Main Main { get; set; }

        Wind Wind { get; set; }

        Sys Sys { get; set; }

        string City { get; set; }

        string Message { get; set; }
    }
}
