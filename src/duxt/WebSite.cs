using System.Text.RegularExpressions;
using duxt.component;
using duxt.exception;
using duxt.styles;

namespace duxt;

public sealed partial class WebSite
{
    public readonly WebContext Context;
    public readonly Dictionary<Type, IComponent> Bodies;

    public WebSite()
    {
        Context = new();
        Bodies = [];
    }

    public void AddBodySlot<T>() where T : IBodyContent, new()
    {
        var bodyComponent = new T() as IBodyContent;

        if (!Bodies.TryAdd(typeof(T), bodyComponent.Invoke(Context)))
        {
            throw new BodyContentExists<T>();
        }
    }

    public void AddGlobalStyle(string styleName, Styles style) =>
        AddGlobalStyles([(styleName, style)]);
    public void AddGlobalStyles(List<(string, Styles)> styles) =>
        Context.Styles.AddRange(styles);

    public string DisplayPage<T>() where T : IBodyContent
    {
        if (!Bodies.TryGetValue(typeof(T), out IComponent? body))
        {
            throw new PageNotExists<T>();
        }

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
        }.Display();

        return NoIndentation()
        .Replace(html, m =>
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
        });
    }

    [GeneratedRegex(@"\s*<|>\s*|\s{2,}|\r\n|\r|\n")]
    private static partial Regex NoIndentation();
}
