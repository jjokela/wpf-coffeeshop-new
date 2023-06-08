using System.Globalization;
using System.Windows.Data;
using WiredBrainsCoffee.CustomersApp.Enums;

namespace WiredBrainsCoffee.CustomersApp.Converter
{
    public class NavigationSideToGridColumnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var navigationSide = (Enums.NavigationSide)value;
            // return navigationSide enum's value
            return navigationSide switch
            {
                NavigationSide.Left => 0,
                NavigationSide.Right => 2,
                _ => throw new ArgumentOutOfRangeException(nameof(value), value, "value should be either Left or Right")
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("This converter cannot be used in two-way binding.");
        }
    }
}
