using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace BMIcalc.Converts
{
    internal class NumberColorConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return new SolidColorBrush(Colors.YellowGreen);
            if (value is double @double)
            {
                if (@double <= 18.5)
                    return new SolidColorBrush(Colors.Blue);
                if (@double >= 24)
                    return new SolidColorBrush(Colors.Red);
            }

            return new SolidColorBrush(Colors.YellowGreen);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}