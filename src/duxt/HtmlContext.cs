using duxt.head;
using duxt.styles;

namespace duxt;

public class HtmlContext : IHtmlContext
{
    public HeadElements HeadElements { get; }
    public StylesElement Styles { get; }

    public HtmlContext()
    {
        HeadElements = new();
        Styles = new();
    }
}
