using duxt.component;

namespace duxt;

public interface IBodyContent
{
    IComponent Invoke(WebContext context);
}