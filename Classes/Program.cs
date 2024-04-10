using System;
using System.IO;
using System.Windows.Forms;

namespace WeatherApp.Classes
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var apiService = new ApiService();
            var weatherData = new WeatherData();
            string apiKey = File.ReadAllText("api.txt");

            Application.Run(new WeatherForm(apiService, weatherData, apiKey));
        }
    }
}
