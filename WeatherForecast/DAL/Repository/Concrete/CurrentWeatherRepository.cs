using System.Threading.Tasks;
using Core.Domain.CurrentWeather;
using DAL.Infrastructure.Interaface;
using DAL.Repository.Interface;

namespace DAL.Repository.Concrete
{
    public class CurrentWeatherRepository : IWeatherRepository<CurrentWeather>
    {
        private IWebClient client;

        private IDeserializer<CurrentWeather> deserializer;

        private IOpenWeatherQueryBuider qBuilder;

        public CurrentWeatherRepository(IWebClient client, IOpenWeatherQueryBuider qBuilder, IDeserializer<CurrentWeather> deserializer)
        {
            this.client = client;
            this.qBuilder = qBuilder;
            this.deserializer = deserializer;
        }

        public async Task<CurrentWeather> GetWeatherAsync(string cityName)
        {
            var uri = this.qBuilder.GetCurrentWeatherUri(cityName);
            var xml = await this.client.GetResponseAsync(uri);

            return this.deserializer.GetTypeInstanceFromXML(xml);
        }
    }
}