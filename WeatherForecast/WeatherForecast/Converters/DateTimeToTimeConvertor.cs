using System;
using System.Globalization;
using System.Windows.Data;

namespace WeatherForecast.Converters
{
    public class DateTimeToTimeConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime)
            {
                DateTime test = (DateTime)value;
                string date = test.ToShortTimeString();
                return date;
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}