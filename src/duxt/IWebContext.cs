using duxt.head;
using duxt.styles;

namespace duxt;

public interface IWebContext
{
    Heads Heads { get; }
    StylesElement Styles { get; }
}
