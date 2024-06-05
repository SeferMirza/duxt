namespace duxt.component;

public class Head(List<(string, string)> _elements, List<(string href, string rel)>? _links = default)
    : Component()
{
    public override string Display()
    {
        var elementsAsComponent = _elements?.Select(e =>
            $"<{e.Item1}>{e.Item2}</{e.Item1}>"
        );
        var linksAsComponent = _links?.Select(e =>
            $"<link href=\"{e.href}\" rel=\"{e.rel}\"></link>"
        );
        var elementsAsString = elementsAsComponent != null
            ? string.Join("\n", elementsAsComponent)
            : string.Empty;
        var linksAsString = linksAsComponent != null
            ? string.Join("\n", linksAsComponent)
            : string.Empty;

        return $"<head> {elementsAsString} {linksAsString} </head>".HtmlIndentation();
    }
}
