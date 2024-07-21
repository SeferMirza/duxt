using duxt.component;
using duxt.head;
using duxt.styles;

namespace duxt;

public class WebContext : IWebContext
{
    public Heads Heads { get; }
    public List<(string styleName, Styles styles)> Styles { get; }
    public List<Script> Scripts { get; set; }

    public WebContext()
    {
        Heads = new();
        Styles = [];
        Scripts = [];
    }
}
