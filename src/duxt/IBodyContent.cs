
using duxt.component;

namespace duxt;

public interface IBodyContent
{
    IComponent Invoke(HtmlContext context, HttpClient client);
}