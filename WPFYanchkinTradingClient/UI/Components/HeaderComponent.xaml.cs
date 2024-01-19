using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPFYanchkinTradingClient.UI.Components
{
    /// <summary>
    /// Логика взаимодействия для HeaderComponent.xaml
    /// </summary>
    public partial class HeaderComponent : UserControl
    {
        public HeaderComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обрабочтик зажатия ЛКМ на header
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                Application.Current.MainWindow.DragMove();
            }
        }

        /// <summary>
        /// Обработчик клика по кнопке Minimize
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMinimizeClick(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Обработчик клика по кнопке Maximize
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMaximizeClick(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
                MaximizeButton.Style = (Style)this.TryFindResource("ButtonHeaderMaximize");
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
                MaximizeButton.Style = (Style)this.TryFindResource("ButtonHeaderUnmaximize");
            }
        }

        /// <summary>
        /// Обработчик клика по кнопке Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
