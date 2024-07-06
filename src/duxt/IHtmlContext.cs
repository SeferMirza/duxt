using duxt.head;
using duxt.styles;

namespace duxt;

public interface IHtmlContext
{
    HeadBlock HeadElements { get; }
    StylesElement Styles { get; }
}
