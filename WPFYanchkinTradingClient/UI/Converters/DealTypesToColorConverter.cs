using System;
using System.Windows.Media;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using WPFYanchkinTradingClient.Contracts.Enums;

namespace WPFYanchkinTradingClient.UI.Converters
{
    /// <summary>
    /// Конвертер <see cref="DealTypes"/>~<see cref="Color"/> 
    /// </summary>
    public class DealTypesToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Enum.TryParse(typeof(DealTypes), value.ToString(), out object? dealerStatus))
            {
                if ((DealTypes)dealerStatus == DealTypes.Unknown)
                    return new SolidColorBrush((Color)Application.Current.FindResource("ColorUnknown"));
                return new SolidColorBrush((Color)Application.Current.FindResource("ColorDealTypes" + dealerStatus.ToString()));
            }
            return new SolidColorBrush((Color)Application.Current.FindResource("ColorUnknown"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
