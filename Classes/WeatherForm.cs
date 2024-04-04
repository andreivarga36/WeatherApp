using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp.Classes;  

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        private readonly ApiService apiService;
        private readonly ApiHandler apiHandler;
        private readonly string apiKey;
        private WeatherInfo weatherInfo;

        public WeatherForm()
        {
            InitializeComponent();
            apiKey = File.ReadAllText("api.txt");

            apiService = new ApiService();
            apiHandler = new ApiHandler();

            textBox.KeyPress += TextBoxKeyPress;
            FormClosing += ReleaseResources;
        }

        private async void SearchButtonClick(object sender, EventArgs e)
        {
            await DisplayWeather();
        }

        private async Task DisplayWeather()
        {
            string city = textBox.Text;

            try
            {
                string responseContent = await apiService.RetrieveWeatherInformationAsync(city, apiKey);
                weatherInfo = apiHandler.DeserializeObject(responseContent);

                if (ValidateCity())
                {
                    DisplayOverviewWeatherInfo();
                }
                else
                {
                    MessageBox.Show("Please enter a valid city/country name!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DisplayOverviewWeatherInfo()
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

        private void DisplayPicIcon() => picIcon.ImageLocation = $"http://openweathermap.org/img/w/{weatherInfo.Weather[0].Icon}.png";

        private static DateTimeOffset ConvertUnixTimeStampToLocalTime(long unixTimestamp) => DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);

        private void DisplayWeatherConditionInfo()
        {
            labConditions.Text = weatherInfo.Weather[0].Main;
            labDetails.Text = weatherInfo.Weather[0].Description;
        }

        private void DisplaySunriseAndSunsetInfo()
        {
            DateTimeOffset sunriseTime = ConvertUnixTimeStampToLocalTime(weatherInfo.Sys.Sunrise);
            DateTimeOffset sunsetTime = ConvertUnixTimeStampToLocalTime(weatherInfo.Sys.Sunset);

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

        private void ReleaseResources(object sender, FormClosingEventArgs e)
        {
            apiService.ReleaseResources();
            Dispose();
        }

        private async void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                await DisplayWeather();
            }
        }

        private bool ValidateCity()
        {
            string city = textBox.Text;

            return weatherInfo.Message != "city not found" && !string.IsNullOrEmpty(city);
        }
    }
}
