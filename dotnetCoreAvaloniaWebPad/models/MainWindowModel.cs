namespace dotnetCoreAvaloniaWebPad.models;

public class MainWindowModel: nac.Forms.model.ViewModelBase
{
    public string CSSText
    {
        get { return GetValue(() => CSSText); }
        set { SetValue(() => CSSText, value);}
    }

    public string JavascriptText
    {
        get { return GetValue(() => JavascriptText); }
        set { SetValue(() => JavascriptText, value);}
    }

    public string HTMLText
    {
        get { return GetValue(() => HTMLText); }
        set { SetValue(() => HTMLText, value);}
    }
    
    
}