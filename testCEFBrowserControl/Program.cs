using System;
using Avalonia;
using nac.Forms;

namespace testCEFBrowserControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = Avalonia.AppBuilder.Configure<nac.Forms.App>()
                .NewForm();

            f.Text("Hello World!");
            
            // make a browser 
            var browser = new WebViewControl.WebView();
            browser.Initialized += (_sender, _args) =>
            {
                Console.WriteLine("Web View Initialized");
                browser.LoadUrl("https://www.google.com");
            };
            
            f._Extend_AddRowToHost(browser, rowAutoHeight: false);
            
            f.Display();
        }
    }
}
