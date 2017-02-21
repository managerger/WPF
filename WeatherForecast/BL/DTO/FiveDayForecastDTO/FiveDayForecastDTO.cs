using System.Collections.Generic;
using Core.Domain.FiveDayForecast;

namespace BL.DTO.FiveDayForecastDTO
{
    public class FiveDayForecastDTO
    {
        public string City { get; set; }

        public ICollection<ThreeHourForecastDTO> WeatherInfos { get; set; }

        public FiveDayForecastDTO(FiveDayForecast weather)
        {
            this.City = weather.Location.City;
            this.WeatherInfos = new List<ThreeHourForecastDTO>();

            foreach (var time in weather.ThreeHourForecasts)
            {
                this.WeatherInfos.Add(new ThreeHourForecastDTO(time));
            }
        }
    }
}