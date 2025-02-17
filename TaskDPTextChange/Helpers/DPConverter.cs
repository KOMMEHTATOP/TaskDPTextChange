using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace TaskDPTextChange.Helpers
{
    public class DPConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string colorName)
            {
                try
                {
                    Color color = (Color)ColorConverter.ConvertFromString(colorName);
                    return new SolidColorBrush(color);
                }
                catch (FormatException ex)
                {
                    return Brushes.Black; 
                }
            }
            return Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
