using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Avalonia.DesktopPlayground.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void InputElement_OnTapped(object? sender, RoutedEventArgs e)
        {
            MainText.Text = "gejs";
        }
    }
}