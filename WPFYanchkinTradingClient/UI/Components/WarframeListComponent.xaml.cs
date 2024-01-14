using System.Windows.Controls;
using WPFYanchkinTradingClient.ViewModels;

namespace WPFYanchkinTradingClient.UI.Components
{
    /// <summary>
    /// Логика взаимодействия для ItemListComponent.xaml
    /// </summary>
    public partial class WarframeListComponent : UserControl
    {
        public WarframeListComponent()
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
