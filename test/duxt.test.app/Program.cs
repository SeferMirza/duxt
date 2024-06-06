using duxt.app;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "images")),
    RequestPath = "/images"
});

app.MapGet("/", () => Results.Content(Pages.Index, "text/html"));

app.Run();
