using System.Windows;
using System.Windows.Controls;


namespace TaskDPTextChange.View
{
    public partial class TextSettingsControl : UserControl
    {
        public TextSettingsControl()
        {
            InitializeComponent();
        }

        public string TextColor
        {
            get { return (string)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public static readonly DependencyProperty TextColorProperty =
            DependencyProperty.Register("TextColor", typeof(string), typeof(TextSettingsControl), new PropertyMetadata("Black"));

        public bool IsBold
        {
            get { return (bool)GetValue(IsBoldProperty); }
            set { SetValue(IsBoldProperty, value); }
        }

        public static readonly DependencyProperty IsBoldProperty =
            DependencyProperty.Register("IsBold", typeof(bool), typeof(TextSettingsControl), new PropertyMetadata(false));

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register("FontSize", typeof(double), typeof(TextSettingsControl), new PropertyMetadata(14.0));


    }
}
