using duxt.component;
using duxt.styles;

namespace duxt.app;

public class Container(List<Component> slot, string? @class = default, string? id = default, Styles? styles = default)
    : Component(slot, @class, id, "div", styles)
{
    public override string Display() => Slot.Display();
}
