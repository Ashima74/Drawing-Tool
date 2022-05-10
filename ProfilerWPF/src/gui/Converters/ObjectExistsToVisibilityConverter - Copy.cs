using System;
using System.Globalization;
using System.Windows.Data;

namespace ProfilerWPF.gui.Converters
{
    public class ObjectNotExistsToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //If the button contains list items then add a drop down symbol
            return value==null ? "Visible" : "Collapsed";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
