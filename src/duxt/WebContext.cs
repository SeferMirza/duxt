using duxt.head;
using duxt.scripts;
using duxt.styles;

namespace duxt;

public class WebContext : IWebContext
{
    public Heads Heads { get; }
    public StylesElement Styles { get; }
    public ScriptsElement Scripts { get; set; }

    public WebContext()
    {
        Heads = new();
        Styles = new();
        Scripts = new();
    }
}
