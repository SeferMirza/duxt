using System.Dynamic;
using System.Net.Http.Headers;
using System.Text.Json;
using duxt.component;
using HtmlAgilityPack;

namespace duxt.app.components;

public class Projects : Component
{
    private readonly HttpClient _client;

    public Projects(HttpClient client)
        : base([new H2("My Projects")], new("div", "projects-container centered-content column", default), default)
    {
        _client = client;
        _client.BaseAddress = new Uri("https://api.github.com/");
    }

    public override string Display()
    {
        List<Component> projects = GetProjects();
        Slot.Add(new Div(slot: projects, @class: "projects"));

        return base.Display();
    }

    List<Component> GetProjects()
    {
        List<Component> result = [];
        List<string> pinnedProject = GetPinned(user: "SeferMirza");

        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github+json"));
        _client.DefaultRequestHeaders.Add("X-GitHub-Api-Version", "2022-11-28");
        _client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");

        Console.WriteLine("sending request to {0}{1}", _client.BaseAddress, "users/sefermirza/repos");
        var response = _client.GetAsync("users/sefermirza/repos").Result;
        Console.WriteLine("response: {0} ({1})", (int)response.StatusCode, response.ReasonPhrase);

        if (response.IsSuccessStatusCode)
        {
            var responseAsString = response.Content.ReadAsStringAsync().Result;
            dynamic[] responseAsObject = JsonSerializer.Deserialize<ExpandoObject[]>(responseAsString)!;
            foreach (var repository in responseAsObject.Where(r => pinnedProject.Any(p => p == r.name.GetString())))
            {
                // Every repository object is JsonElement and if you get string value
                // u must be use GetString Method
                // look here: https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonelement.getstring?view=net-8.0
                result.Add(
                    new Card(
                        "./images/code.jpg",
                        repository.name.GetString(),
                        repository.full_name.GetString(),
                        repository.html_url.GetString()
                    )
                );
            }
        }
        else
        {
            result.Add(new H4("No Project Found!"));
        }

        return result;
    }

    List<string> GetPinned(string user)
    {
        List<string> result = [];

        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));
        string htmlContent = _client.GetStringAsync($"https://github.com/{user}").Result;

        var doc = new HtmlDocument();
        doc.LoadHtml(htmlContent);
        var olNode = doc.DocumentNode.SelectSingleNode("//ol");
        if (olNode != null)
        {
            foreach (var liNode in olNode.SelectNodes("li"))
            {
                var spanNode = liNode.SelectSingleNode(".//span[@class='repo']");
                if (spanNode != null)
                {
                    result.Add(spanNode.InnerText);
                }
            }
        }

        return result;
    }
}
