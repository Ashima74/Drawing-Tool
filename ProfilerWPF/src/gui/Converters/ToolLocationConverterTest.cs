using System;
using System.Globalization;
using System.Windows.Data;

namespace ProfilerWPF.gui.Converters
{
    public class ToolLocationConverterTest : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var ToolLocation = ((float x, float y, float z))value;
            return $"Tool Position(MO): x = {ToolLocation.x}, y = {ToolLocation.y}, z = {ToolLocation.z}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
