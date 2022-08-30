using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace Avalonia.DesktopPlayground.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MainButton_OnTapped(object? sender, RoutedEventArgs e)
        {
            MainText.Text = "Tu i gejs";
        }
    }
}