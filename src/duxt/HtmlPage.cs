using duxt.component;

namespace duxt;

public sealed class WebSite
{
    public readonly WebContext Context;
    public readonly HttpClient Client;
    public readonly Dictionary<Type, string> Bodies;

    public WebSite()
    {
        Context = new();
        Client = new();
        Bodies = [];
    }

    public void AddBodySlot<T>() where T : IBodyContent, new()
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
                    Slot = [Context.Heads.Title, .. Context.Heads.Links, .. Context.Heads.Metas]
                },
                new Body
                {
                    Slot = [body]
                },
                new Style(Context.Styles)
            ]
        };

        Bodies.TryAdd(typeof(T), html.Display());
    }

    public string DisplayBody<T>() where T : IBodyContent
    {
        Bodies.TryGetValue(typeof(T), out string body);
        return body;
    }
}
