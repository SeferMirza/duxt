using duxt.app.pages;
using Microsoft.Extensions.FileProviders;

namespace duxt.app.services;

public static class StaticFilesExtensions
{
    public static void StaticFiles(this WebApplication app)
    {
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
    }
}
