using duxt.component;
using duxt.head;
using duxt.styles;

namespace duxt;

public interface IWebContext
{
    Heads Heads { get; }
    List<(string styleName, Styles styles)> Styles { get; }
    List<Script> Scripts { get; set;}
}
