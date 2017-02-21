using System.Threading.Tasks;
using Core.Domain.FiveDayForecast;
using DAL.Infrastructure.Interaface;
using DAL.Repository.Interface;

namespace DAL.Repository.Concrete
{
    public class FiveDayForecastRepository : IWeatherRepository<FiveDayForecast>
    {
        private IWebClient client;

        private IDeserializer<FiveDayForecast> deserializer;

        private IOpenWeatherQueryBuider qBuilder;

        public FiveDayForecastRepository(IWebClient client, IOpenWeatherQueryBuider qBuilder, IDeserializer<FiveDayForecast> deserializer)
        {
            this.client = client;
            this.qBuilder = qBuilder;
            this.deserializer = deserializer;
        }

        public async Task<FiveDayForecast> GetWeatherAsync(string cityName)
        {
            var uri = this.qBuilder.GetFiveDayForecastUri(cityName);
            var xml = await this.client.GetResponseAsync(uri);

            return this.deserializer.GetTypeInstanceFromXML(xml);
        }
    }
}