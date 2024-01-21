using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFYanchkinTradingClient.UI.Controls
{
    /// <summary>
    /// Логика взаимодействия для FilterBox.xaml
    /// </summary>
    public partial class FilterBox : UserControl
    {
        public string Hint
        {
            get => (string)GetValue(HintProperty);
            set => SetValue(HintProperty, value);
        }

        public string FilterSelectedItem
        {
            get => (string)GetValue(FilterSelectedItemProperty);
            set => SetValue(FilterSelectedItemProperty, value);
        }

        public ObservableCollection<string> FilterItemsSource
        {
            get => (ObservableCollection<string>)GetValue(FilterItemsSourceProperty);
            set => SetValue(FilterItemsSourceProperty, value);
        }

        public FilterBox()
        {
            InitializeComponent();
        }

        #region props
        public static readonly DependencyProperty HintProperty =
            DependencyProperty.Register(
                    "Hint",
                    typeof(string),
                    typeof(FilterBox),
                    null);
        public static readonly DependencyProperty FilterSelectedItemProperty =
          DependencyProperty.Register(
                  "FilterSelectedItem",
                  typeof(string),
                  typeof(FilterBox),
                  null);
        public static readonly DependencyProperty FilterItemsSourceProperty =
         DependencyProperty.Register(
                 "FilterItemsSource",
                 typeof(ObservableCollection<string>),
                 typeof(FilterBox),
                 null);
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FilterSelectedItem = null;
        }
    }
}
