using Microsoft.Extensions.FileProviders;

namespace duxt.app;

public static class StaticFilesExtensions
{
    public static void StaticFiles(this WebApplication app)
    {
        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "scripts")
            ),
            RequestPath = "/scripts"
        });

        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "public")
            ),
            RequestPath = ""
        });
    }
}
