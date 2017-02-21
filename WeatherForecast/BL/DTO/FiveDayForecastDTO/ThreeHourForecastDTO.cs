using System;
using Core.Domain.FiveDayForecast;

namespace BL.DTO.FiveDayForecastDTO
{
    public class ThreeHourForecastDTO
    {
        public DateTime Date { get; set; }

        public double Humidity { get; set; }

        public string Icon { get; set; }

        public double Pressure { get; set; }

        public double TemperatureMax { get; set; }

        public double TemperatureMin { get; set; }

        public double WindSpeed { get; set; }

        public ThreeHourForecastDTO(ThreeHourForecast time)
        {
            this.Date = time.From;
            this.Humidity = time.Humidity.Value;
            this.Icon = time.Symbol.Var;
            this.Pressure = time.Pressure.Value;
            this.TemperatureMax = time.Temperature.Max;
            this.TemperatureMin = time.Temperature.Min;
            this.WindSpeed = time.WindSpeed.ValueForecast;
        }
    }
}