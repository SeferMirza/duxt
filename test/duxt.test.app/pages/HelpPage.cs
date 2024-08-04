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
                                Class = "command",
                                Slot = [
                                    new Span
                                    {
                                        Class = "pointer",
                                        Slot = [new Text("⇒&nbsp;")]
                                    },
                                    new Text("about")]
                            },
                            new Li
                            {
                                Class = "command",
                                Slot = [
                                    new Span
                                    {
                                        Class = "pointer",
                                        Slot = [new Text("⇒&nbsp;")]
                                    },
                                    new Text("links")
                                ]
                            },
                            new Li
                            {
                                Class = "command",
                                Slot = [
                                    new Span
                                    {
                                        Class = "pointer",
                                        Slot = [new Text("⇒&nbsp;")]
                                    },
                                    new Text("skills")
                                ]
                            },
                            new Li
                            {
                                Class = "command",
                                Slot = [
                                    new Span
                                    {
                                        Class = "pointer",
                                        Slot = [new Text("⇒&nbsp;")]
                                    },
                                    new Text("cls")
                                ]
                            },
                            new Li
                            {
                                Class = "command",
                                Slot = [
                                    new Span
                                    {
                                        Class = "pointer",
                                        Slot = [new Text("⇒&nbsp;")]
                                    },
                                    new Text("help")
                                ]
                            }
                        ]
                    }
                ]
            };
    }
}
