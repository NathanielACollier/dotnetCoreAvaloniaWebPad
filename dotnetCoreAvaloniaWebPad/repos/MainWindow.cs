using dotnetCoreAvaloniaWebPad.extensions;
using nac.Forms;

namespace dotnetCoreAvaloniaWebPad.repos;

public static class MainWindow
{

    private static models.MainWindowModel model { get; } = new models.MainWindowModel();
    
    public static void Run()
    {
        var f = Avalonia.AppBuilder.Configure<nac.Forms.App>()
            .NewForm();

        f.DataContext = model;

        f.Text("WebPad")
            .Menu(new[]
            {
                new nac.Forms.model.MenuItem
                {
                    Header = "File",
                    Items = new[]
                    {
                        new nac.Forms.model.MenuItem
                        {
                            Header = "Save",
                            Action = saveMenuClick
                        }
                    }
                }
            })
            .VerticalGroup(_browserAndEditorAreaVG =>
            {
                _browserAndEditorAreaVG.HorizontalGroup(_editorArea =>
                {
                    _editorArea.VerticalGroup(_htmlEditorArea =>
                    {
                        _htmlEditorArea.Text("HTML")
                            .TextBoxFor(nameof(model.HTMLText));
                    }).VerticalGroup(_jsCSSEditorArea =>
                    {
                        _jsCSSEditorArea.VerticalGroup(_jsEditorArea =>
                        {
                            _jsEditorArea.Text("Javascript")
                                .TextBoxFor(nameof(model.JavascriptText));
                        }).VerticalGroup(_cssEditorArea =>
                        {
                            _cssEditorArea.Text("CSS")
                                .TextBoxFor(nameof(model.CSSText));
                        });
                    });
                }, isSplit: true)
                .VerticalGroup(_browserVG =>
                {
                    _browserVG.Text("Result")
                        .Browser();
                });
            }, isSplit:true)
            .Display();
    }

    private static void saveMenuClick()
    {
            
    }
        
}