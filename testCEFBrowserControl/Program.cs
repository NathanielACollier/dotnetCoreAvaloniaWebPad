using System;
using Avalonia;
using CefGlue.Avalonia;

namespace testCEFBrowserControl
{
    class Program
    {
        static void Main(string[] args)
        {
            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseSkia()
                .ConfigureCefGlue(args)
                .Start<MainWindow>();
        }
    }
}
