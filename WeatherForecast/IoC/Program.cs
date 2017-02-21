using System;
using AppStart.IoC;
using SimpleInjector;
using WeatherForecast;

namespace AppStart
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DependencyInjector injector = new DependencyInjector();
            RunApplication(injector.container);
        }

        private static void RunApplication(Container container)
        {
                var app = new App();
                var mainWindow = container.GetInstance<MainWindow>();
                app.Run(mainWindow);
        }
    }
}