using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Input;
using BL.DTO.CurrentWeatherDTO;
using BL.DTO.FiveDayForecastDTO;
using BL.Service.Interface;
using ViewModel.Infrastructure.Concrete;

namespace ViewModel.WeatherViewModels
{
    public class MainViewModel : Notifier
    {
        private string cityName;

        private string exceptionInfo;

        private IWeatherService<CurrentWeatherDTO> currentWeatherService;

        private IWeatherService<FiveDayForecastDTO> fiveDayForecastWeatherService;

        private ForecastWeatherViewModel forecastWeather;

        public ICommand AddCommand { get; private set; }

        public ICommand AddForecastCommand { get; private set; }

        public ObservableCollection<CurrentWeatherViewModel> CitiesWeather { get; private set; }

        public string CityName
        {
            get
            {
                return this.cityName;
            }
            set
            {
                if (this.cityName == value)
                {
                    return;
                }

                this.cityName = value;
                this.OnPropertyChanged();
            }
        }

        public string ExceptionInfo
        {
            get
            {
                return this.exceptionInfo;
            }
            set
            {
                if (this.exceptionInfo == value)
                {
                    return;
                }

                this.exceptionInfo = value;
                this.OnPropertyChanged();
            }
        }

        public ForecastWeatherViewModel ForecastWeather
        {
            get
            {
                return this.forecastWeather;
            }
            set
            {
                if (this.forecastWeather == value)
                {
                    return;
                }

                this.forecastWeather = value;
                this.OnPropertyChanged();
            }
        }

        public ICommand RefreshCommand { get; private set; }

        public ICommand RemoveCommand { get; private set; }

        public MainViewModel(IWeatherService<FiveDayForecastDTO> fiveDayForecastWeatherService,
            IWeatherService<CurrentWeatherDTO> currentWeatherService)
        {
            this.CitiesWeather = new ObservableCollection<CurrentWeatherViewModel>();
            this.currentWeatherService = currentWeatherService;
            this.fiveDayForecastWeatherService = fiveDayForecastWeatherService;
            this.InitializeCommand();
        }

        private void InitializeCommand()
        {
            this.AddCommand = new RelayCommand(obj => this.AddCurrentWeatherAsync(), canExecute => !string.IsNullOrWhiteSpace(this.CityName));
            this.AddForecastCommand = new RelayCommand(obj => this.AddForecastAsync(obj));
            this.RefreshCommand = new RelayCommand(obj => this.RefreshCityWeatherAsync(obj));
            this.RemoveCommand = new RelayCommand(obj => this.RemoveCityWeather(obj));
        }

        private async Task AddCurrentWeatherAsync()
        {
            var currentWeather = await this.GetCurrentWeatherAsync(this.CityName);
            if (currentWeather == null)
            {
                return;
            }

            var city = this.CitiesWeather.FirstOrDefault(c => c.CityName == currentWeather.CityName);
            if (city == null)
            {
                this.CitiesWeather.Add(currentWeather);
                this.CityName = string.Empty;
            }
        }

        private async Task AddForecastAsync(object cityName)
        {
            try
            {
                var forecast = await this.fiveDayForecastWeatherService.GetWeatherAsync(cityName.ToString());
                this.ForecastWeather = new ForecastWeatherViewModel(forecast);
            }
            catch (WebException e)
            {
                this.ExceptionInfo = string.Format("{0}", e.Message);
            }
            finally
            {
                this.ExceptionInfo = string.Empty;
            }
        }

        private async Task<CurrentWeatherViewModel> GetCurrentWeatherAsync(string cityName)
        {
            try
            {
                var currentWeatherDTO = await this.currentWeatherService.GetWeatherAsync(cityName);
                this.ExceptionInfo = string.Empty;
                return new CurrentWeatherViewModel(currentWeatherDTO);
            }
            catch (WebException e)
            {
                this.ExceptionInfo = string.Format("{0}", e.Message);
                return null;
            }
        }

        private async Task RefreshCityWeatherAsync(object cityName)
        {
            var currentWeather = await this.GetCurrentWeatherAsync(cityName.ToString());
            var oldWeather = this.CitiesWeather.FirstOrDefault(c => c.CityName == cityName.ToString());
            if (oldWeather != null && currentWeather !=null)
            {
                var index = this.CitiesWeather.IndexOf(oldWeather);
                this.CitiesWeather.Remove(oldWeather);
                this.CitiesWeather.Insert(index, currentWeather);
            }
        }

        private void RemoveCityWeather(object cityName)
        {
            var city = this.CitiesWeather.FirstOrDefault(c => c.CityName == cityName.ToString());

            if (city != null)
            {
                this.CitiesWeather.Remove(city);
            }

            if (this.ForecastWeather != null && cityName.ToString() == this.ForecastWeather.CityName)
            {
                this.ForecastWeather = null;
            }
        }
    }
}