using duxt;
using duxt.app;
using duxt.app.pages;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
var web = Builder.CreateHtml();
web.SetTitle("duxt");
web.AddLinks([
    new(href: "https://fonts.googleapis.com", rel: "preconnect"),
    new(href: "https://fonts.gstatic.com", rel: "preconnect"),
    new(href: "https://fonts.googleapis.com/css2?family=VT323&display=swap", rel: "stylesheet")
]);
web.AddMeta(new(properties: ("charset", "UTF8")));
web.AddGlobalStyles([
    CommonStyles.Body,
    CommonStyles.Content,
    CommonStyles.Font
]);

web.AddBodySlot<IndexPage>();
web.AddBodySlot<AboutPage>();
// web.AddBodySlot<BlogPage>();
web.AddBodySlot<ContactPage>();
web.AddBodySlot<PortfolioPage>();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "images")
    ),
    RequestPath = "/images"
});
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "scripts")
    ),
    RequestPath = "/scripts"
});

app.MapGet("/", () => Results.Content(web.DisplayPage<IndexPage>(), "text/html"));
app.MapGet("/about", () => Results.Content(web.DisplayPage<AboutPage>(), "text/html"));
// app.MapGet("/blog", () => Results.Content(web.DisplayPage<BlogPage>(), "text/html"));
app.MapGet("/contact", () => Results.Content(web.DisplayPage<ContactPage>(), "text/html"));
app.MapGet("/portfolio", () => Results.Content(web.DisplayPage<PortfolioPage>(), "text/html"));

app.Run();
