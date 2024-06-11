namespace duxt.head;

public class LinkElements
{
    public readonly List<(string href, string rel)> Links;

    public LinkElements()
    {
        Links = [];
    }

    public void Add(string href, string rel)
    {
        Links.Add((href, rel));
    }

    public void Add(List<(string href, string rel)> values)
    {
        values.ForEach(x => Links.Add((x.href, x.rel)));
    }

    public string HtmlView()
    {
        var linksAsHeadElement = Links.Select(e =>
            $"<link href=\"{e.href}\" rel=\"{e.rel}\">"
        );

        var linksAsHtmlView = linksAsHeadElement != null
            ? string.Join("\n", linksAsHeadElement)
            : string.Empty;

        return linksAsHtmlView;
    }
}
