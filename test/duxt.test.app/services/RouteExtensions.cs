using duxt.app.pages;

namespace duxt.app.services;

public static class RouteExtensions
{
    public static void AddRoutes(this WebApplication app, WebSite web)
    {
        app.MapGet("/", () => Results.Content(web.DisplayPage<IndexPage>(), "text/html"));
        app.MapGet("/about", () => Results.Content(web.DisplayPage<AboutPage>(), "text/html"));
        // app.MapGet("/blog", () => Results.Content(web.DisplayPage<BlogPage>(), "text/html"));
        app.MapGet("/contact", () => Results.Content(web.DisplayPage<ContactPage>(), "text/html"));
        app.MapGet("/portfolio", () => Results.Content(web.DisplayPage<PortfolioPage>(), "text/html"));
    }
}
