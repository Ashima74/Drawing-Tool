using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;

namespace ProfilerWPF.gui.Converters
{
    public class MouseLocationToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var MouseLocation = ((float x, float y, float z)) value;
            return $"Cursor Position(MO): x = {MouseLocation.x}, y = {MouseLocation.y}, z = {MouseLocation.z}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
