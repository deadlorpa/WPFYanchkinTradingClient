using System.Windows;
using System.Windows.Controls;

namespace WPFYanchkinTradingClient.UI.Controls
{
    /// <summary>
    /// Логика взаимодействия для TagBox.xaml
    /// </summary>
    public partial class TagBox : UserControl
    {
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        
        public TagBox()
        {
            InitializeComponent();
        }

        #region private fields
        private static readonly DependencyProperty TextProperty = DependencyProperty.Register(
                    "Text",
                    typeof(string),
                    typeof(TagBox),
                    new FrameworkPropertyMetadata(
                        string.Empty, null));
        #endregion
    }
}
