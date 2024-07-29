using duxt.app.pages;

namespace duxt.app;

public static class RouteExtensions
{
    public static void AddRoutes(this WebApplication app, WebSite web)
    {
        app.MapGet("/", () => Results.Content(web.DisplayPage<IndexPage>(), "text/html"));
        app.MapGet("/about", () => Results.Content(web.Bodies[typeof(AboutPage)].Display(), "text/html"));
        app.MapGet("/links", () => Results.Content(web.Bodies[typeof(LinksPage)].Display(), "text/html"));
        app.MapGet("/skills", () => Results.Content(web.Bodies[typeof(SkillsPage)].Display(), "text/html"));
    }
}
