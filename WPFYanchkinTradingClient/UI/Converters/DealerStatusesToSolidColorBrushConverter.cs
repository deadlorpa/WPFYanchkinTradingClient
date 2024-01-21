using System;
using System.Windows.Media;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using WPFYanchkinTradingClient.Contracts.Enums;

namespace WPFYanchkinTradingClient.UI.Converters
{
    /// <summary>
    /// Конвертер <see cref="DealerStatuses"/>~<see cref="Color"/> 
    /// </summary>
    public class DealerStatusesToSolidColorBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(Enum.TryParse(typeof(DealerStatuses), value.ToString(), out object? dealerStatus))
            {
                if((DealerStatuses)dealerStatus == DealerStatuses.Unknown)
                    return (SolidColorBrush)Application.Current.FindResource("ColorBrushUnknown");
                return (SolidColorBrush)Application.Current.FindResource("ColorDealerStatus" + dealerStatus.ToString());
            }
            return (SolidColorBrush)Application.Current.FindResource("ColorBrushUnknown");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
