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
        var displayedBodyComponent = bodyComponent.Invoke(_context).Display();

        return @$"
            <html>
                <head>
                    {_context.HeadElements.Title.HtmlView()}
                    {_context.HeadElements.Links.HtmlView()}
                    {_context.HeadElements.Metas.HtmlView()}
                </head>
                <body>
                    {displayedBodyComponent}
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
