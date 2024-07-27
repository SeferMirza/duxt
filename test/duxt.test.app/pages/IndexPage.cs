using duxt.component;

namespace duxt.app.pages;

public class IndexPage : IBodyContent
{
    public IComponent Invoke(WebContext context)
    {
        context.Scripts.Add(new("scripts/main.js"));

        return
            new Div
            {
                Class = "container",
                Slot = [
                    new Div
                    {
                        Id = "terminal",
                        Slot = [
                            new P(string.Empty)
                            {
                                Id = "history",
                                Slot = [
                                    new Text("Welcome to my world!<br>To get information about me use:&nbsp;"),
                                    new Span{
                                        Class = "command",
                                        Slot = [new Text("about")]
                                    },
                                    new Text("<br>To see my links:&nbsp;"),
                                    new Span{
                                        Class = "command",
                                        Slot = [new Text("links")]
                                    },
                                    new Text("<br>To see my skills:&nbsp;"),
                                    new Span{
                                        Class = "command",
                                        Slot = [new Text("skills")]
                                    },
                                    new Text("<br>To clear history:&nbsp;"),
                                    new Span{
                                        Class = "command",
                                        Slot = [new Text("cls")]
                                    }
                                ]
                            },
                            new Div
                            {
                                Class = "entry",
                                Slot = [
                                    new Label
                                    {
                                        Id = "label",
                                        OtherProperties = {{"for", "input"}},
                                        Slot = [
                                            new Text("C:\\> ")
                                        ]
                                    },
                                    new Input("text")
                                    {
                                        Id = "input",
                                        OtherProperties = {{"name", "input"}, {"autofocus", string.Empty}}
                                    }
                                ]
                            }
                        ]
                    }
                ]
            };
    }
}
