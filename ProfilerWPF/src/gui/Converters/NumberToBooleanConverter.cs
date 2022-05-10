using System;
using System.Globalization;
using System.Windows.Data;

namespace ProfilerWPF.gui.Converters
{
    public class NumberToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((long?)value == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;

            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
