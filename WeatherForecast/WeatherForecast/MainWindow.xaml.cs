using System.Windows;
using ViewModel.WeatherViewModels;

namespace WeatherForecast
{
    public partial class MainWindow : Window
    {
        private MainViewModel mainViewModel;

        public MainWindow(MainViewModel mainViewModel)
        {
            this.InitializeComponent();
            this.mainViewModel = mainViewModel;
            this.DataContext = mainViewModel;
        }
    }
}