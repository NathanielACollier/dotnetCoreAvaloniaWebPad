using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace testCEFBrowserControl{
    class MainWindow : Window
    {
        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);
            this.AttachDevTools();
        }
    }
}