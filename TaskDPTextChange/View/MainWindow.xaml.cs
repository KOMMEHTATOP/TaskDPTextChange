using System.Windows;
using TaskDPTextChange.ViewModel;


namespace TaskDPTextChange;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}