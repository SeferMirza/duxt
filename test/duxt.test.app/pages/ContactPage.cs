using duxt.app.components;
using duxt.component;

namespace duxt.app.pages;

public class ContactPage : IBodyContent
{
    public IComponent Invoke(WebContext context)
    {
        return
            new Div
            {
                Class = "container monospace centered-content",
                Slot = [
                    new Banner("Sefer Mirza | FullStack Developer")
                ]
            };
    }
}
