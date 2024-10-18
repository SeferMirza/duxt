using duxt.app.components;
using duxt.component;

namespace duxt.app.pages;

public class SkillsPage : IBodyContent
{
    public IComponent Invoke(WebContext context)
    {
        return
            new Div
            {
                Class = "skills-container",
                Slot = [
                    new P("I can assist you with"),
                    new StarList([
                            "C#, JavaScript, Python(beginner)",
                            ".NET Core, ASP.NET Core, ASP.NET Core MVC",
                            "MSSQL, MYSQL, Sqlite, PostgreSQL",
                            "Node.js, Express.js",
                            "Git, GitHub",
                            "Docker/Kubernetes",
                            "Redis",
                            "Flask",
                            "NUnit"
                        ]),
                    new Div
                    {
                        Class = "not-container",
                        Slot = [
                            new Span
                            {
                                Class = "pointer",
                                Slot = [new Text("⇒&nbsp;")]
                            },
                            new P(string.Empty)
                            {
                                Class = "note",
                                Slot = [
                                    new Text("Available for freelance, remote or contact based opportunities. Use the"),
                                    new Span
                                    {
                                        Class = "command",
                                        Slot = [new Text("'links'")]
                                    },
                                    new Text("command to see links to contact.")
                                ]
                            }
                        ]
                    }
                ]
            };
    }
}
