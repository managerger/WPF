using System.Threading.Tasks;
using BL.DTO.CurrentWeatherDTO;
using BL.Service.Interface;
using Core.Domain.CurrentWeather;
using DAL.Repository.Interface;

namespace BL.Service.Concrete
{
    public class CurrentWeatherService : IWeatherService<CurrentWeatherDTO>
    {
        private IWeatherRepository<CurrentWeather> repository;

        public CurrentWeatherService(IWeatherRepository<CurrentWeather> repository)
        {
            this.repository = repository;
        }

        public async Task<CurrentWeatherDTO> GetWeatherAsync(string cityName)
        {
            var weather = await this.repository.GetWeatherAsync(cityName);

            return new CurrentWeatherDTO(weather);
        }
    }
}