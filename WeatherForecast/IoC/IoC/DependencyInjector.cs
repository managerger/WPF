using BL.DTO.CurrentWeatherDTO;
using BL.DTO.FiveDayForecastDTO;
using BL.Service.Concrete;
using BL.Service.Interface;
using Core.Domain.CurrentWeather;
using Core.Domain.FiveDayForecast;
using DAL.Infrastructure.Concrete;
using DAL.Infrastructure.Interaface;
using DAL.Repository.Concrete;
using DAL.Repository.Interface;
using SimpleInjector;
using ViewModel.WeatherViewModels;
using WeatherForecast;

namespace AppStart.IoC
{
    internal sealed class DependencyInjector
    {
        public Container container { get; private set; }

        public DependencyInjector()
        {
            this.container = new Container();
            this.RegistreDependency(this.container);
        }

        private void RegistreDependency(Container container)
        {
            this.container.Options.DefaultLifestyle = Lifestyle.Transient;

            //DAL
            this.container.Register<IOpenWeatherQueryBuider, OpenWeatherQueryBuilder>();
            this.container.Register<IDeserializer<FiveDayForecast>, Deserializer<FiveDayForecast>>();
            this.container.Register<IDeserializer<CurrentWeather>, Deserializer<CurrentWeather>>();
            this.container.Register<IWebClient, WebClient>();
            this.container.Register<IWeatherRepository<FiveDayForecast>, FiveDayForecastRepository>();
            this.container.Register<IWeatherRepository<CurrentWeather>, CurrentWeatherRepository>();

            //BL
            this.container.Register<IWeatherService<CurrentWeatherDTO>, CurrentWeatherService>();
            this.container.Register<IWeatherService<FiveDayForecastDTO>, FiveDayForecastService>();

            //ViewModel
            this.container.Register<MainViewModel>();

            //View
            this.container.Register<MainWindow>();

            this.container.Verify();
        }
    }
}