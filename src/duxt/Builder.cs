using duxt.component;

namespace duxt;

public sealed class Builder
{
    public static HtmlPage CreateHtml(List<Link>? constantLinks = default, List<Meta>? constantMetas = default, Title? title = default)
    {
        var page = new HtmlPage();

        if (title != null) page.Context.HeadElements.Title = title;
        if (constantLinks != null) page.Context.HeadElements.Links.AddRange(constantLinks);
        if (constantMetas != null) page.Context.HeadElements.Metas.AddRange(constantMetas);

        return page;
    }
}
