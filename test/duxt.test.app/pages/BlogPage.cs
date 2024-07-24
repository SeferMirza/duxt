using duxt.app.components;
using duxt.component;

namespace duxt.app.pages;

public class BlogPage : IBodyContent
{
    public IComponent Invoke(WebContext context)
    {
        return
            new Div
            {
                Class = "blog"
            };
    }
}
