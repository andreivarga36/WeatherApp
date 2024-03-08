using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        private readonly HttpClient httpClient;
        private readonly string apiKey;
        private readonly string errorMessage;
        private readonly string picURL;
        private WeatherInfo weatherInfo;

        public WeatherForm()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            apiKey = File.ReadAllText("api.txt");
            errorMessage = "City was not found, please make sure the name is correct!";
            picURL = "http://openweathermap.org/img/w/";
        }

        private async void SearchButtonClick(object sender, EventArgs e)
        {
            await GetWeather();
        }

        private async Task GetWeather()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={textBox.Text}&appid={apiKey}&units=metric");
                await HandleWeatherResponse(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task HandleWeatherResponse(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(json);

                DisplayWeatherInfo();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void DisplayWeatherInfo()
        {
            DisplayLocationInfo();
            DisplayTemperatureInfo();
            DisplayWeatherConditionInfo();
            DisplaySunriseAndSunsetInfo();
            DisplayWindInfo();
            DisplayPressureAndHumidityInfo();
            DisplayPicIcon();
        }

        private void DisplayLocationInfo() => labCityInfo.Text = $"{weatherInfo.City}, {weatherInfo.Sys.Country}";

        private void DisplayTemperatureInfo() => labDegrees.Text = $"{weatherInfo.Main.Temp:0.0°} C";

        private void DisplayWeatherConditionInfo()
        {
            labConditions.Text = weatherInfo.Weather[0].Main;
            labDetails.Text = weatherInfo.Weather[0].Description;
        }

        private void DisplayPicIcon() => picIcon.ImageLocation = $"{picURL}{weatherInfo.Weather[0].Icon}.png";

        private void DisplaySunriseAndSunsetInfo()
        {
            DateTimeOffset sunriseTime = DateTimeOffset.FromUnixTimeSeconds(weatherInfo.Sys.Sunrise);
            DateTimeOffset sunsetTime = DateTimeOffset.FromUnixTimeSeconds(weatherInfo.Sys.Sunset);

            labSunrise.Text = $"{sunriseTime: HH : mm}";
            labSunset.Text = $"{sunsetTime: HH : mm}";
        }

        private void DisplayWindInfo()
        {
            double windSpeedInKmPerHour = weatherInfo.Wind.Speed * 3.6;
            labWindSpeed.Text = $"{windSpeedInKmPerHour:0.0} km/h";
        }

        private void DisplayPressureAndHumidityInfo()
        {
            labPressure.Text = $"{weatherInfo.Main.Pressure}";
            labHumidity.Text = $"{weatherInfo.Main.Humidity}%";
        }
    }
}
