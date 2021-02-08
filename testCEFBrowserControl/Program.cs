using System;
using Avalonia;
using CefNet.CApi;
using dotnetCoreAvaloniaNCForms;

namespace testCEFBrowserControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = Avalonia.AppBuilder.Configure<dotnetCoreAvaloniaNCForms.App>()
                .NewForm();

            f.Text("Hello World!");
            
            // make a browser 
            var browser = new CefNet.Avalonia.WebView();
            browser.Initialized += (_sender, _args) =>
            {
                Console.WriteLine("Web View Initialized");
                //browser.Navigate("https://www.google.com");
            };
            
            f._Extend_AddRowToHost(browser, rowAutoHeight: false);
            
            f.Display();
        }
    }
}
