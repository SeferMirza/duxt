using duxt.component;
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

    public string Slot<T>() where T : IBodyContent, new()
    {
        var bodyComponent = new T() as IBodyContent;
        // BodyComponents must be called before context.HeadElement is displayed
        // because the Title, Links and Metas can be added in the BodyComponent.
        var body = bodyComponent.Invoke(Context, Client);
        var html = new Html
        {
            Slot = [
                new Head
                {
                    Slot = [Context.HeadElements.Title, .. Context.HeadElements.Links, .. Context.HeadElements.Metas]
                },
                new Body
                {
                    Slot = [body]
                },
                new Style(Context.Styles)
            ]
        };

        return html.Display();
    }

    public HtmlPage Head(Action<HeadBlock> action)
    {
        action(Context.HeadElements);

        return this;
    }
}
