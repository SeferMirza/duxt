using System.Text.RegularExpressions;
using duxt.component;
using duxt.exception;

namespace duxt;

public sealed partial class WebSite
{
    public readonly WebContext Context;
    public readonly Dictionary<Type, string> Pages;

    public WebSite()
    {
        Context = new();
        Pages = [];
    }

    public void AddBodySlot<T>() where T : IBodyContent, new()
    {
        var bodyComponent = new T() as IBodyContent;
        // BodyComponents must be called before context.HeadElement is displayed
        // because the Title, Links and Metas can be added in the BodyComponent.
        var body = bodyComponent.Invoke(Context);
        var html = new Html
        {
            Slot = [
                new Head
                {
                    Slot = [Context.Heads.Title, .. Context.Heads.Links, .. Context.Heads.Metas, .. Context.Scripts]
                },
                new Body
                {
                    Slot = [body]
                },
                new Style(Context.Styles)
            ]
        };

        if(!Pages.TryAdd(typeof(T), html.Display()))
        {
            throw new BodyContentExists<T>();
        }
    }

    public string DisplayPage<T>() where T : IBodyContent =>
        Pages.TryGetValue(typeof(T), out string? page)
        ? NoIndentation().Replace(page, m =>
            {
                if (m.Value.Contains('<'))
                {
                    return "<";
                }
                else if (m.Value.Contains('>'))
                {
                    return ">";
                }
                else
                {
                    return " ";
                }
            })
        : throw new PageNotExists<T>();

    [GeneratedRegex(@"\s*<|>\s*|\s{2,}|\r\n|\r|\n")]
    private static partial Regex NoIndentation();
}
