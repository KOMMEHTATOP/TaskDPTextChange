
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Controls;

namespace TaskDPTextChange.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _text = string.Empty;

        public string Text
        {
            get { return _text; }
            set
            {
                if (_text != value)
                {
                    _text = value;
                    OnPropertyChange(nameof(Text));
                }
            }
        }

        private string _textColor = "Black";

        public string TextColor
        {
            get { return _textColor; }
            set
            {
                if (_textColor != value)
                {
                    _textColor = value;
                    OnPropertyChange(nameof(TextColor));
                    Debug.WriteLine($"Свойство TextColor изменилось {value}");
                }
            }
        }

        private ComboBoxItem _selectedTextColor;
        public ComboBoxItem SelectedTextColor
        {
            get => _selectedTextColor;
            set
            {
                if (_selectedTextColor != value)
                {
                    _selectedTextColor = value;
                    TextColor = value?.Tag?.ToString(); // Получаем Tag и преобразуем в string
                    OnPropertyChange(nameof(SelectedTextColor));
                }
            }
        }


        private double _fontSize;

        public double FontSize
        {
            get { return _fontSize; }
            set
            {
                if (_fontSize != value)
                {
                    _fontSize = value;
                    OnPropertyChange(nameof(FontSize));
                }
            }
        }

        private bool _isBold;

        public bool IsBold
        {
            get { return _isBold; }
            set
            {
                if (_isBold != value)
                {
                    _isBold = value;
                    OnPropertyChange(nameof(IsBold));
                }
            }
        }


    }
}
