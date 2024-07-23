using duxt.component;

namespace duxt.app.pages;

public class AboutPage : IBodyContent
{
    public IComponent Invoke(WebContext context)
    {
        return
            new Div
            {
                Class = "container monospace centered-content",
                Slot = [
                    new Text("Sefer Mirza")
                ]
            };
    }
}
