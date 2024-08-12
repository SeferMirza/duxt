using duxt.component;

namespace duxt.app.pages;

public class HelpPage : IBodyContent
{
    public IComponent Invoke(WebContext context)
    {
        return
            new Div
            {
                Class = "help-container",
                Slot = [
                    new Div
                    {
                        Slot = [
                            new Text("You can search using the following commands.")
                        ]
                    },
                    new Ul
                    {
                        Class = "list",
                        Slot = [
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "pointer",
                                        Slot = [new Text("⇒&nbsp;")]
                                    },
                                    new Span()
                                    {
                                        Class = "command",
                                        Slot = [new Text("about")]
                                    },
                                    new Text("- About me.")
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "pointer",
                                        Slot = [new Text("⇒&nbsp;")]
                                    },
                                    new Span()
                                    {
                                        Class = "command",
                                        Slot = [new Text("books")]
                                    },
                                    new Text("- It gives a list of books I have read or am reading.")
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "pointer",
                                        Slot = [new Text("⇒&nbsp;")]
                                    },
                                    new Span()
                                    {
                                        Class = "command",
                                        Slot = [new Text("links")]
                                    },
                                    new Text("- It lists my available links.")
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "pointer",
                                        Slot = [new Text("⇒&nbsp;")]
                                    },
                                    new Span()
                                    {
                                        Class = "command",
                                        Slot = [new Text("skills")]
                                    },
                                    new Text("- It shows the skills I have acquired in my career as a professional developer.")
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "pointer",
                                        Slot = [new Text("⇒&nbsp;")]
                                    },
                                    new Span()
                                    {
                                        Class = "command",
                                        Slot = [new Text("cls")]
                                    },
                                    new Text("- It cleans the terminal.")
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "pointer",
                                        Slot = [new Text("⇒&nbsp;")]
                                    },
                                    new Span()
                                    {
                                        Class = "command",
                                        Slot = [new Text("help")]
                                    },
                                    new Text("- Lists available commands.")
                                ]
                            }
                        ]
                    }
                ]
            };
    }
}
