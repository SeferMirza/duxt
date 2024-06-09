using duxt.head;

namespace duxt;

public sealed class HtmlPage
{
    private readonly HtmlContext _context;

    public HtmlPage()
    {
        _context = new();
    }

    public string Slot<T>() where T : IBodyComponent, new()
    {
        var bodyComponent = new T() as IBodyComponent;

        return @$"
            <html>
                <head>
                    {_context.HeadElements.PropertyElements.HtmlView()}
                    { _context.HeadElements.Links.HtmlView()}
                </head>
                <body>
                    {bodyComponent.Invoke(_context)}
                </body>
                <style>
                    {_context.Styles.HtmlView()}
                </style>
            </html>".HtmlIndentation();
    }

    public HtmlPage Head(Action<HeadElements> action)
    {
        action(_context.HeadElements);

        return this;
    }
}
