
using System.ComponentModel;
using System.Drawing;

namespace TaskDPTextChange.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChange(object parameter)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(parameter)));
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
                    OnPropertyChange(Text);
                }
            }
        }

        private Color _textColor;

        public Color TextColor
        {
            get { return _textColor; }
            set
            {
                if (_textColor != value)
                {
                    _textColor = value;
                    OnPropertyChange(TextColor);
                }
            }
        }

        private double _fontSizeText;

        public double FontSizeText
        {
            get { return _fontSizeText; }
            set
            {
                if (_fontSizeText != value)
                {
                    _fontSizeText = value;
                    OnPropertyChange(FontSizeText);
                }
            }
        }

        private bool _isBoldText;

        public bool IsBoldText
        {
            get { return _isBoldText; }
            set
            {
                if (_isBoldText != value)
                {
                    _isBoldText = value;
                    OnPropertyChange(IsBoldText);
                }
            }
        }


    }
}
