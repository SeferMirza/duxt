using duxt.component;

namespace duxt;

public static class WebExtensions
{
    public static WebSite AddLink(this WebSite page, Link link) =>
        page.AddLinks([link]);
    public static WebSite AddLinks(this WebSite page, List<Link> links)
    {
        page.Context.Heads.Links.AddRange(links);

        return page;
    }

    public static WebSite AddMeta(this WebSite page, Meta meta) =>
        page.AddMetas([meta]);
    public static WebSite AddMetas(this WebSite page, List<Meta> metas)
    {
        page.Context.Heads.Metas.AddRange(metas);

        return page;
    }

    public static WebSite SetTitle(this WebSite page, string title)
    {
        page.Context.Heads.Title = new(title);

        return page;
    }
}
