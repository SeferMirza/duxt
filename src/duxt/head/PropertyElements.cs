namespace duxt.head;

public class PropertyElements
{
    public readonly List<(string tag, string value)> Properties;

    public PropertyElements()
    {
        Properties = [];
    }

    public void Add(string tag, string value)
    {
        Properties.Add((tag, value));
    }

    public string HtmlView()
    {
        var elementsAsHeadElement = Properties?.Select(e =>
            $"<{e.tag}>{e.value}</{e.tag}>"
        );

        var elementsAsHtmlView = elementsAsHeadElement != null
            ? string.Join("\n", elementsAsHeadElement)
            : string.Empty;

        return elementsAsHtmlView;
    }
}
