namespace DAL.Infrastructure.Interaface
{
    public interface IOpenWeatherQueryBuider
    {
        string GetCurrentWeatherUri(string city);

        string GetFiveDayForecastUri(string city);
    }
}