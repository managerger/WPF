using System.Threading.Tasks;
using BL.DTO.FiveDayForecastDTO;
using BL.Service.Interface;
using Core.Domain.FiveDayForecast;
using DAL.Repository.Interface;

namespace BL.Service.Concrete
{
    public class FiveDayForecastService : IWeatherService<FiveDayForecastDTO>
    {
        private IWeatherRepository<FiveDayForecast> repository;

        public FiveDayForecastService(IWeatherRepository<FiveDayForecast> repository)
        {
            this.repository = repository;
        }

        public async Task<FiveDayForecastDTO> GetWeatherAsync(string cityName)
        {
            var weather = await this.repository.GetWeatherAsync(cityName);

            return new FiveDayForecastDTO(weather);
        }
    }
}