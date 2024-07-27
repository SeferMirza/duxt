using duxt.app.pages;

namespace duxt.app;

public static class RouteExtensions
{
    public static void AddRoutes(this WebApplication app, WebSite web)
    {
        app.MapGet("/", () => Results.Content(web.DisplayPage<IndexPage>(), "text/html"));
        app.MapGet("/about", () => Results.Content(web.Pages[typeof(AboutPage)], "text/html"));
        app.MapGet("/links", () => Results.Content(web.Pages[typeof(LinksPage)], "text/html"));
        app.MapGet("/skills", () => Results.Content(web.Pages[typeof(AboutPage)], "text/html"));
    }
}
