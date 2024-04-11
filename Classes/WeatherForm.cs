using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp.Interfaces;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        private readonly IApiService apiService;
        private readonly string apiKey;
        private IWeatherData weatherData;

        public WeatherForm(IApiService apiService, IWeatherData weatherData, string apiKey)
        {
            InitializeComponent();

            this.apiService = apiService;
            this.weatherData = weatherData;
            this.apiKey = apiKey;

            textBox.KeyPress += TextBoxKeyPress;
            FormClosing += WeatherFormFormClosing;
            UpdateLabelsVisibility(false);
        }

        private void UpdateLabelsVisibility(bool showOrHideLabels)
        {
            labCityInfo.Visible = showOrHideLabels;
            labDegrees.Visible =  showOrHideLabels;
            labConditions.Visible = showOrHideLabels;
            labDetails.Visible = showOrHideLabels;
            labSunrise.Visible = showOrHideLabels;
            labSunset.Visible = showOrHideLabels;
            labWindSpeed.Visible = showOrHideLabels;
            labPressure.Visible = showOrHideLabels;
            labHumidity.Visible = showOrHideLabels;
        }

        private async void SearchButtonClick(object sender, EventArgs e)
        {
            await DisplayWeather();
        }

        private async Task DisplayWeather()
        {
            try
            {
                await DisplayWeatherData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task DisplayWeatherData()
        {
            string city = textBox.Text;
            string responseContent = await apiService.RetrieveWeatherInformationAsync(city, apiKey);

            weatherData = apiService.DeserializeObject(responseContent);
            DisplayOverviewWeatherInfo();
            UpdateLabelsVisibility(true);
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

        private void DisplayLocationInfo() => labCityInfo.Text = $"{weatherData.City}, {weatherData.Sys.Country}";

        private void DisplayTemperatureInfo() => labDegrees.Text = $"{weatherData.Main.Temp:0.0°} C";

        private void DisplayPicIcon() => picIcon.ImageLocation = $"http://openweathermap.org/img/w/{weatherData.Weather[0].Icon}.png";

        private static DateTimeOffset ConvertUnixTimeStampToLocalTime(long unixTimestamp) => DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);

        private void DisplayWeatherConditionInfo()
        {
            labConditions.Text = weatherData.Weather[0].Main;
            labDetails.Text = weatherData.Weather[0].Description;
        }

        private void DisplaySunriseAndSunsetInfo()
        {
            DateTimeOffset sunriseTime = ConvertUnixTimeStampToLocalTime(weatherData.Sys.Sunrise);
            DateTimeOffset sunsetTime = ConvertUnixTimeStampToLocalTime(weatherData.Sys.Sunset);

            labSunrise.Text = $"{sunriseTime: HH : mm}";
            labSunset.Text = $"{sunsetTime: HH : mm}";
        }

        private void DisplayWindInfo()
        {
            double windSpeedInKmPerHour = weatherData.Wind.Speed * 3.6;
            labWindSpeed.Text = $"{windSpeedInKmPerHour:0.0} km/h";
        }

        private void DisplayPressureAndHumidityInfo()
        {
            labPressure.Text = $"{weatherData.Main.Pressure}";
            labHumidity.Text = $"{weatherData.Main.Humidity}%";
        }


        private async void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                await DisplayWeather();
            }
        }

        private void WeatherFormFormClosing(object sender, FormClosingEventArgs e)
        {
            apiService.DisposeClient();
        }
    }
}
