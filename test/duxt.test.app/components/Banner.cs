using duxt.component;
using duxt.styles;

namespace duxt.app.components;

public class Banner(string? title = default, Styles? styles = default) : Component
{
    public override string Tag { get; } = "div";
    public override string? Class { get; set; } = "banner centered-content";
    public override Styles? Styles { get; set; } = styles;
    public override List<IComponent>? Slot { get; set; } = [ new H1(title ?? string.Empty) { Class = "monospace" }];
}