using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace testCEFBrowserControl.views{
    public class Main: UserControl{

        public Main(){
            AvaloniaXamlLoader.Load(this);

            var browser = this.FindControl<CefGlue.Avalonia.AvaloniaCefBrowser>("browserCtrl");
        }

    }
}