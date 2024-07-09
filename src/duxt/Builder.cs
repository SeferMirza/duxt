using duxt.component;

namespace duxt;

public sealed class Builder
{
    public static WebSite CreateHtml(List<Link>? constantLinks = default, List<Meta>? constantMetas = default, Title? title = default)
    {
        var page = new WebSite();

        if (title != null) page.Context.Heads.Title = title;
        if (constantLinks != null) page.Context.Heads.Links.AddRange(constantLinks);
        if (constantMetas != null) page.Context.Heads.Metas.AddRange(constantMetas);

        return page;
    }
}
