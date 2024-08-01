using duxt.component;

namespace duxt.app.pages;

public class IndexPage : IBodyContent
{
    public IComponent Invoke(WebContext context)
    {
        var terminalJs = new Script();
        terminalJs.OtherProperties.Add("src", "scripts/terminal.js");
        context.Scripts.Add(terminalJs);

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
                                    new Br(),
                                    new Text("To see my links:&nbsp;"),
                                    new Span{
                                        Class = "command",
                                        Slot = [new Text("links")]
                                    },
                                    new Br(),
                                    new Text("To see my skills:&nbsp;"),
                                    new Span{
                                        Class = "command",
                                        Slot = [new Text("skills")]
                                    },
                                    new Br(),
                                    new Text("To clear history:&nbsp;"),
                                    new Span{
                                        Class = "command",
                                        Slot = [new Text("cls")]
                                    },
                                    new Br()
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
                                            new Span{
                                                Class = "variable",
                                                Slot = [new Text("you@sefermirza.dev")]
                                            },
                                            new Text(":"),
                                            new Span{
                                                Class = "special-character",
                                                Slot = [new Text("~")]
                                            },
                                            new Text("$&nbsp;")
                                        ]
                                    },
                                    new Input("text")
                                    {
                                        Id = "input",
                                        OtherProperties = {{"name", "input"}, {"autofocus", string.Empty}}
                                    },
                                    new Br()
                                ]
                            }
                        ]
                    }
                ]
            };
    }
}
