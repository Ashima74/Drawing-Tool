using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using ProfilerWPF.gui.DataTypes.Interfaces;

namespace ProfilerWPF.gui.Converters
{
    public class ListContainsToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //If the button contains list items then add a drop down symbol
            return ((List<ContextMenuItem>)value).Count >= 1 ? "Visible" : "Collapsed";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
