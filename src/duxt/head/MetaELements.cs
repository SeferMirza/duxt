namespace duxt.head;

public class MetaELements
{
    public readonly List<(string name, string content, string? property)> Metas;

    public MetaELements()
    {
        Metas = [];
    }

    public void Add(string name, string content, string? property = default)
    {
        Metas.Add((name, content, property));
    }

    public void Add(List<(string name, string content, string? property)> metas)
    {
        metas.ForEach(x => Metas.Add((x.name, x.content, x.property)));
    }

    public string HtmlView()
    {
        var metasAsHeadElement = Metas.Select(m =>
            $"<meta name=\"{m.name}\" content=\"{m.content}\" property=\"{m.property}\">"
        );

        var metasAsHtmlView = metasAsHeadElement != null
            ? string.Join("\n", metasAsHeadElement)
            : string.Empty;

        return metasAsHtmlView;
    }
}
