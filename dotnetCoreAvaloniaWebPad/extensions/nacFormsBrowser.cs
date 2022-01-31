namespace dotnetCoreAvaloniaWebPad.extensions;

public static class nacFormsBrowser
{

    public static nac.Forms.Form Browser(this nac.Forms.Form f)
    {
        // make a browser 
        var browser = new WebViewControl.WebView();
        browser.Initialized += (_sender, _args) =>
        {
            System.Console.WriteLine("Web View Initialized"); // todo: change this to some kind of logging
            browser.LoadUrl("https://www.google.com");
        };
            
        f._Extend_AddRowToHost(browser, rowAutoHeight: false);

        return f;
    }
}