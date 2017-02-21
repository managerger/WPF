using System.Windows;
using ViewModel.WeatherViewModels;

namespace WeatherForecast
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel mainViewModel)
        {
            this.InitializeComponent();
            this.DataContext = mainViewModel;
        }
    }
}