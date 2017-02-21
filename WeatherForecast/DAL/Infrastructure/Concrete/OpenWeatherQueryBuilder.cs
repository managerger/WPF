using System.Configuration;
using DAL.Infrastructure.Interaface;

namespace DAL.Infrastructure.Concrete
{
    public class OpenWeatherQueryBuilder : IOpenWeatherQueryBuider
    {
        private readonly string key = ConfigurationManager.AppSettings["OWMAPIKey"];

        public string GetCurrentWeatherUri(string city)
        {
            return string.Format("{0}{1}{2}&{3}&{4}&{5}", 
                QueryStrings.Host, QueryStrings.Weather, city, QueryStrings.Unit, QueryStrings.Mode, key);
        }

        public string GetFiveDayForecastUri(string city)
        {
            return string.Format("{0}{1}{2}&{3}&{4}&{5}", 
                QueryStrings.Host, QueryStrings.Forecast, city, QueryStrings.Unit, QueryStrings.Mode, key);
        }

        private static class QueryStrings
        {
            public const string Forecast = "/forecast?q=";

            public const string Host = "http://api.openweathermap.org/data/2.5";

            public const string Mode = "mode=xml";

            public const string Unit = "units=metric";

            public const string Weather = "/weather?q=";
        }
    }
}