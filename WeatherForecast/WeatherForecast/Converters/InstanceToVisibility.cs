using System;
using System.Globalization;
using System.Windows.Data;

namespace WeatherForecast.Converters
{
    public class InstanceToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return Visibility.Hidden;
            }

            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private static class Visibility
        {
            public const string Hidden = "Hidden";

            public const string Visible = "Visible";
        }
    }
}