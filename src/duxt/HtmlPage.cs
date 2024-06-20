using duxt.head;

namespace duxt;

public sealed class HtmlPage
{
    public readonly HtmlContext Context;
    public readonly HttpClient Client;

    public HtmlPage()
    {
        Context = new();
        Client = new();
    }

    public string Slot<T>() where T : IBodyComponent, new()
    {
        var bodyComponent = new T() as IBodyComponent;
        // BodyComponents must be called before context.HeadElement is displayed
        // because the Title, Links and Metas can be added in the BodyComponent.
        var displayedBodyComponent = bodyComponent.Invoke(Context, Client).Display();

        return @$"
            <html>
                <head>
                    {Context.HeadElements.Title.HtmlView()}
                    {Context.HeadElements.Links.HtmlView()}
                    {Context.HeadElements.Metas.HtmlView()}
                </head>
                <body>
                    {displayedBodyComponent}
                    {Context.Scripts.HtmlView()}
                </body>
                <style>
                    {Context.Styles.HtmlView()}
                </style>
            </html>".HtmlIndentation();
    }

    public HtmlPage Head(Action<HeadElements> action)
    {
        action(Context.HeadElements);

        return this;
    }
}
