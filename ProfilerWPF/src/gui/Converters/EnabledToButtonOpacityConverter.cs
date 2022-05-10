using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ProfilerWPF.gui.Converters
{
    class EnabledToButtonOpacityConverter : IValueConverter
    {
        public object Convert(object isEnabled, Type targetType, object parameter, CultureInfo culture)
        {
            return ((bool)isEnabled) ? "1" : "0.5";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
