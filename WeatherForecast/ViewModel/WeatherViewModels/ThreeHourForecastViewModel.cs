using System;
using BL.DTO.FiveDayForecastDTO;

namespace ViewModel.WeatherViewModels
{
    public class ThreeHourForecastViewModel
    {
        public DateTime Date { get; set; }

        public double Humidity { get; set; }

        public string Icon { get; set; }

        public int Pressure { get; set; }

        public double TemperatureMax { get; set; }

        public double TemperatureMin { get; set; }

        public double WindSpeed { get; set; }

        public ThreeHourForecastViewModel(ThreeHourForecastDTO time)
        {
            this.Date = time.Date;
            this.Humidity = time.Humidity;
            this.Icon = time.Icon;
            this.Pressure = (int)time.Pressure;
            this.TemperatureMax = time.TemperatureMax;
            this.TemperatureMin = time.TemperatureMin;
            this.WindSpeed = time.WindSpeed;
        }
    }
}
