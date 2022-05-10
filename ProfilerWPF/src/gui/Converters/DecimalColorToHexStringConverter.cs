using System;
using System.Globalization;
using System.Windows.Data;

namespace ProfilerWPF.gui.Converters
{
    public class DecimalColorToHexStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                Int64 dec = (Int64) value;

                string hexValue = dec.ToString("X");

                if (hexValue.Length != 6)
                {
                    hexValue = hexValue.PadLeft(6, '0');
                }

                return "#" + hexValue;
            }
            else
            {
                return "#00000";

            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
