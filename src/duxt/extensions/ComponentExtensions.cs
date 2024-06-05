using duxt.component;
using duxt.styles;

namespace duxt;

public static class ComponentExtensions
{
    public static Html Html(this Builder _, Head head, Body body, Dictionary<string, Styles>? styles = default) =>
        new(head, body, styles);

    public static string Display(this List<Component> components) =>
        string.Join("\n", components.Select(s => s.Display()));
}
