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
        // BodyComponents must be called before context.HeadElement is displayed
        // because the Title, Links and Metas can be added in the BodyComponent.
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
                    {_context.Scripts.HtmlView()}
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
