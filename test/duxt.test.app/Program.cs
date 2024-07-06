using duxt;
using duxt.app.pages;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
var htmlPage = Builder.CreateHtml();
var page = htmlPage.Head(headElements =>
{
    headElements.Links.Add(new(href: "https://fonts.googleapis.com", rel: "preconnect"));
    headElements.Links.Add(new(href: "https://fonts.gstatic.com", rel: "preconnect"));
    headElements.Links.Add(new(href: "https://fonts.googleapis.com/css2?family=VT323&display=swap", rel: "stylesheet"));
    headElements.Title = new("duxt");
});

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "images")),
    RequestPath = "/images"
});
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "scripts")),
    RequestPath = "/scripts"
});

app.MapGet("/", () => Results.Content(page.Slot<IndexPage>(), "text/html"));

app.Run();
