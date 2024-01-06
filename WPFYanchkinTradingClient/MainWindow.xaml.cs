using System.Windows;
using WPFYanchkinTradingClient.ViewModels;

namespace WPFYanchkinTradingClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new WarframeVM();
        }
    }
}
