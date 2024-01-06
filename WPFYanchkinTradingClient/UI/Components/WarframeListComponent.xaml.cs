using System.Windows.Controls;
using WPFYanchkinTradingClient.ViewModels;

namespace WPFYanchkinTradingClient
{
    /// <summary>
    /// Логика взаимодействия для ItemListComponent.xaml
    /// </summary>
    public partial class ItemListComponent : UserControl
    {
        public ItemListComponent()
        {
            InitializeComponent();
            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if(this.DataContext != null)
            {
                ((WarframeVM)this.DataContext).OnViewLoaded();
            }
        }
    }
}
