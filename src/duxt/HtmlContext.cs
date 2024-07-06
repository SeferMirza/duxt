using duxt.head;
using duxt.scripts;
using duxt.styles;

namespace duxt;

public class HtmlContext : IHtmlContext
{
    public HeadBlock HeadElements { get; }
    public StylesElement Styles { get; }
    public ScriptsElement Scripts { get; set; }

    public HtmlContext()
    {
        HeadElements = new();
        Styles = new();
        Scripts = new();
    }
}
