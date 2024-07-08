using duxt.component;

namespace duxt;

public static class PageExtensions
{
    public static HtmlPage AddLink(this HtmlPage page, Link link) =>
        page.AddLinks([link]);
    public static HtmlPage AddLinks(this HtmlPage page, List<Link> links)
    {
        page.Context.HeadElements.Links.AddRange(links);

        return page;
    }

    public static HtmlPage AddMeta(this HtmlPage page, Meta meta) =>
        page.AddMetas([meta]);
    public static HtmlPage AddMetas(this HtmlPage page, List<Meta> metas)
    {
        page.Context.HeadElements.Metas.AddRange(metas);

        return page;
    }

    public static HtmlPage SetTitle(this HtmlPage page, string title)
    {
        page.Context.HeadElements.Title = new(title);

        return page;
    }
}
