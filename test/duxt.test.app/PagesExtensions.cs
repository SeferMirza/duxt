using System.Text;
using duxt.app.pages;

namespace duxt.app;

public static class PagesExtensions
{
    public static void AddPages(this WebSite web)
    {
        web.AddBodySlot<IndexPage>();
        web.AddBodySlot<AboutPage>();
        web.AddBodySlot<LinksPage>();
        web.AddBodySlot<SkillsPage>();
        web.AddBodySlot<HelpPage>();
    }

    static string RoutesTemplate(List<string> values) => @$"
{{
    {string.Join(",\n", values.Select(v => $"\"{v}\": \"{v}.html\""))}
}}";

    public static void Publish(this WebSite web)
    {
        Directory.CreateDirectory("../../generate");
        Directory.CreateDirectory("../../generate/scripts");

        //pages
        File.WriteAllText("../../generate/index.html", web.DisplayPage<IndexPage>(), Encoding.UTF8);
        web.Bodies
            .Where(body => body.Key != typeof(IndexPage))
            .ToList()
            .ForEach(body =>
                File.WriteAllText($"../../generate/{body.Key.Name.Replace("Page", "").ToLowerInvariant()}.html", web.Bodies[body.Key].Display(), Encoding.UTF8)
            );

        //routes
        var bodiesName = web.Bodies.Select(body => body.Key.Name.Replace("Page", "").ToLowerInvariant()).ToList();
        var routeJs = RoutesTemplate(bodiesName);

        File.WriteAllText($"../../generate/scripts/routes.json", routeJs, Encoding.UTF8);

        //scripts
        foreach(var script in web.Context.Scripts)
        {
            if(script.OtherProperties.TryGetValue("src", out var filePath))
            {
                File.Copy(filePath, $"../../generate/{filePath}", overwrite: true);
            }
        }

        //public
        string[] files = Directory.GetFiles("./public").Select(file => Path.GetFileName(file)).ToArray();
        foreach(var file in files)
        {
            File.Copy($"./public/{file}", $"../../generate/{file}", overwrite: true);
        }
    }
}
