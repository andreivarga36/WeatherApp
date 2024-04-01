namespace WeatherApp.Interfaces
{
    internal interface IApiHandler
    {
        WeatherInfo DeserializeObject(string responseContent);
    }
}
