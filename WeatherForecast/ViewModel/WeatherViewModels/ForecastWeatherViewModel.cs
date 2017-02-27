using System;
using System.Collections.Generic;
using System.Linq;
using BL.DTO.FiveDayForecastDTO;

namespace ViewModel.WeatherViewModels
{
    public class ForecastWeatherViewModel
    {
        private DateTime minDateInForecast;

        public string CityName { get; private set; }

        public string FirstDay { get; private set; }

        public string FourthDay { get; private set; }

        public string SecondDay { get; private set; }

        public string ThirdDay { get; private set; }

        public string Today { get; private set; }

        public ICollection<ThreeHourForecastViewModel> WeatherFirstDay { get; private set; }

        public ICollection<ThreeHourForecastViewModel> WeatherFourthDay { get; private set; }

        public ICollection<ThreeHourForecastViewModel> WeatherSecondDay { get; private set; }

        public ICollection<ThreeHourForecastViewModel> WeatherThirdDay { get; private set; }

        public ICollection<ThreeHourForecastViewModel> WeatherToday { get; private set; }

        public ForecastWeatherViewModel(FiveDayForecastDTO fiveDayForecast)
        {
            if (fiveDayForecast != null && fiveDayForecast.WeatherInfos != null)
            {
                this.minDateInForecast = fiveDayForecast.WeatherInfos.Min(d => d.Date);
                this.CityName = fiveDayForecast.City;
                this.SetWeatherByDays(fiveDayForecast.WeatherInfos);
            }
        }

        private void SetWeatherByDays(ICollection<ThreeHourForecastDTO> weatherForecast)
        {
            this.FirstDay = this.minDateInForecast.AddDays((double)ForecastDayNumbers.FirstDay).DayOfWeek.ToString();
            this.FourthDay = this.minDateInForecast.AddDays((double)ForecastDayNumbers.FourthDay).DayOfWeek.ToString();
            this.SecondDay = this.minDateInForecast.AddDays((double)ForecastDayNumbers.SecondDay).DayOfWeek.ToString();
            this.ThirdDay = this.minDateInForecast.AddDays((double)ForecastDayNumbers.ThirdDay).DayOfWeek.ToString();
            this.Today = this.minDateInForecast.AddDays((double)ForecastDayNumbers.Today).DayOfWeek.ToString();

            this.WeatherFirstDay = this.GetThreeHourForecastPerDay(weatherForecast, (int)ForecastDayNumbers.FirstDay);
            this.WeatherFourthDay = this.GetThreeHourForecastPerDay(weatherForecast, (int)ForecastDayNumbers.FourthDay);
            this.WeatherSecondDay = this.GetThreeHourForecastPerDay(weatherForecast, (int)ForecastDayNumbers.SecondDay);
            this.WeatherThirdDay = this.GetThreeHourForecastPerDay(weatherForecast, (int)ForecastDayNumbers.ThirdDay);
            this.WeatherToday = this.GetThreeHourForecastPerDay(weatherForecast, (int)ForecastDayNumbers.Today);
        }

        private ICollection<ThreeHourForecastViewModel> GetThreeHourForecastPerDay(ICollection<ThreeHourForecastDTO> weatherForecast, int dayNumber)
        {
            var forecastDate = this.minDateInForecast.AddDays(dayNumber).ToShortDateString();

            return weatherForecast.Where(day => day.Date.ToShortDateString() == forecastDate).Select(day => new ThreeHourForecastViewModel(day)).ToList();
        }

        private enum ForecastDayNumbers
        {
            SecondDay = 2,
            FourthDay = 4,
            Today = 0,
            FirstDay = 1,
            ThirdDay = 3
        }
    }
}