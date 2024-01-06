using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WPFYanchkinTradingClient.Contracts.DTO;

namespace WPFYanchkinTradingClient
{
    /// <summary>
    /// Логика взаимодействия для WarframePartDealsTable.xaml
    /// </summary>
    public partial class DealsTable : UserControl
    {
        public ObservableCollection<DealDTO> Deals
        {
            get => (ObservableCollection<DealDTO>)GetValue(DealsProperty);
            set => SetValue(DealsProperty, value);
        }

        public DealsTable()
        {
            InitializeComponent();
        }

        #region props
        public static readonly DependencyProperty DealsProperty =
            DependencyProperty.Register(
                    "Deals",
                    typeof(ObservableCollection<DealDTO>),
                    typeof(DealsTable),
                    null);
        #endregion
    }
}
