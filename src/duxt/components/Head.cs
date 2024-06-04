using System.Xml.Linq;

namespace duxt.component;

public class Head(Dictionary<string, string> _elements)
    : Component()
{
    public override string Display()
    {
        var elementsAsComponent = _elements?.Select(e => $"<{e.Key}>{e.Value}</{e.Key}>");
        var elementsAsString = elementsAsComponent != null
            ? string.Join("\n", elementsAsComponent)
            : string.Empty;

        return XElement.Parse(
            "<head>" +
            elementsAsString +
            "</head>"
        ).ToString();
    }
}