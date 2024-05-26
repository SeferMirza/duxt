namespace duxt;

public class Div(List<Component>? slot = default, string? @class = default, string? id = default, Styles? styles = default)
    : Component(slot, @class, id, "div", styles);
