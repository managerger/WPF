using Core.Domain.CurrentWeather;

namespace BL.DTO.CurrentWeatherDTO
{
    public class CurrentWeatherDTO
    {
        public string City { get; set; }

        public double Humidity { get; set; }

        public string Icon { get; set; }

        public double Pressure { get; set; }

        public double Temperature { get; set; }

        public double WindSpeed { get; set; }

        public CurrentWeatherDTO(CurrentWeather weather)
        {
            this.City = weather.City.Name;
            this.Humidity = weather.Humidity.Value;
            this.Icon = weather.Weather.Icon;
            this.Pressure = weather.Pressure.Value;
            this.Temperature = weather.Temperature.Value;
            this.WindSpeed = weather.WindCharacteristics.Speed.Value;
        }
    }
}