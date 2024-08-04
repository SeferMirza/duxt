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
                    new Ul
                    {
                        Class = "list",
                        Slot = [
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "list-star",
                                        Slot = [new Text("★")]
                                    },
                                    new Text("C#, JavaScript, Python(beginner)")]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "list-star",
                                        Slot = [new Text("★")]
                                    },
                                    new Text(".NET Core, ASP.NET Core, ASP.NET Core MVC")
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "list-star",
                                        Slot = [new Text("★")]
                                    },
                                    new Text("MSSQL, MYSQL")
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "list-star",
                                        Slot = [new Text("★")]
                                    },
                                    new Text("Node.js, Express.js")
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "list-star",
                                        Slot = [new Text("★")]
                                    },
                                    new Text("Git, GitHub")
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "list-star",
                                        Slot = [new Text("★")]
                                    },
                                    new Text("Docker")
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "list-star",
                                        Slot = [new Text("★")]
                                    },
                                    new Text("Flask")
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "list-star",
                                        Slot = [new Text("★")]
                                    },
                                    new Text("NUnit")
                                ]
                            }
                        ]
                    },
                    new Div
                    {
                        Class = "not-container",
                        Slot = [
                            new Span
                            {
                                Class = "pointer",
                                Slot = [new Text("⇒&nbsp;")]
                            },
                            new P("Available for freelance, remote or contact based opportunities.")
                            {
                                Class = "note"
                            }
                        ]
                    }
                ]
            };
    }
}
