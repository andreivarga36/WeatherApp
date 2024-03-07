using System.Net.Http;
using System.Windows.Forms;
using System.IO;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        private readonly HttpClient httpClient;
        private readonly string message;
        private readonly string apiKey;
        private WeatherInfo weatherInfo;

        public WeatherForm()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            apiKey = File.ReadAllText("api.txt");
            message = "City was not found, please make sure the name is correct!";
        }

        private async void SearchButtonClick(object sender, EventArgs e)
        {
              await GetWeater();
        }

        private async Task GetWeater()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={textBox.Text}&appid={apiKey}");
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
                MessageBox.Show(message);
            }
        }

        private void DisplayWeatherInfo()
        {
            DisplayLocationInfo();
            DisplayTemperatureInfo();
            DisplayWeatherConditionInfo();
            DisplayWindInfo();
            DisplayAdditionalWeatherInfo();
        }

        private void DisplayLocationInfo() => labCountry.Text = $"Country:  {weatherInfo.Sys.Country}";

        private void DisplayTemperatureInfo()
        {
            double temperatureInCelsius = weatherInfo.Main.Temp - 273.15f;
            labDegrees.Text = $"{temperatureInCelsius:0.0} °C";
        }

        private void DisplayWeatherConditionInfo()
        {
            labConditions.Text = weatherInfo.Weather[0].Main;
            labDetails.Text = weatherInfo.Weather[0].Description;
            picIcon.ImageLocation = GetPicIconImage();
        }

        private void DisplayWindInfo()
        {
            double windSpeedInKmPerHour = weatherInfo.Wind.Speed * 3.6;
            labWindSpeed.Text = $"{windSpeedInKmPerHour:0.0} km/h";
        }

        private void DisplayAdditionalWeatherInfo()
        {
            labPressure.Text = weatherInfo.Main.Pressure.ToString();
            labHumidity.Text = $"{weatherInfo.Main.Humidity}%";
            labSunrise.Text = ConvertDateTime(weatherInfo.Sys.Sunrise).ToShortTimeString();
            labSunset.Text = ConvertDateTime(weatherInfo.Sys.Sunset).ToShortTimeString();
        }

        private string GetPicIconImage() => "http://openweathermap.org/img/w/" + weatherInfo.Weather[0].Icon + ".png";

        private DateTime ConvertDateTime(long milisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(milisec).ToLocalTime();

            return day;
        }
    }
}
