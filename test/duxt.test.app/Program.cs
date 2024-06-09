using duxt;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var htmlPage = Builder.CreateHtml();
var page = htmlPage.Head(headElements =>
{
    headElements.Links.Add(href: "https://fonts.googleapis.com", rel: "preconnect");
    headElements.Links.Add(href: "https://fonts.gstatic.com", rel: "preconnect");
    headElements.Links.Add(href: "https://fonts.googleapis.com/css2?family=VT323&display=swap", rel: "stylesheet");
    headElements.PropertyElements.Add(tag: "title", value: "duxt");
});

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "images")),
    RequestPath = "/images"
});

app.MapGet("/", () => Results.Content(page.Slot<IndexPage>(), "text/html"));

app.Run();
