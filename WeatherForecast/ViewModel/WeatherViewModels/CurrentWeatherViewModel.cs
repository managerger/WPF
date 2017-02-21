using BL.DTO.CurrentWeatherDTO;

namespace ViewModel.WeatherViewModels
{
    public class CurrentWeatherViewModel
    {
        public string CityName { get; private set; }

        public double Humidity { get; private set; }

        public string Icon { get; private set; }

        public int Pressure { get; private set; }

        public double Temperature { get; private set; }

        public double WindSpeed { get; private set; }

        public CurrentWeatherViewModel(CurrentWeatherDTO currentWeather)
        {
            if (currentWeather != null)
            {
                this.CityName = currentWeather.City;
                this.Humidity = currentWeather.Humidity;
                this.Icon = currentWeather.Icon;
                this.Pressure = (int)currentWeather.Pressure;
                this.Temperature = currentWeather.Temperature;
                this.WindSpeed = currentWeather.WindSpeed;
            }
        }   
    }
}