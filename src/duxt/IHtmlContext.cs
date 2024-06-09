using duxt.head;
using duxt.styles;

namespace duxt;

public interface IHtmlContext
{
    HeadElements HeadElements { get; }
    StylesElement Styles { get; }
}
