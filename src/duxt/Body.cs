namespace duxt;

public class Body(List<Component>? slot = default, string? @class = default, string? id = default, Styles? styles = default)
    : Component(slot ?? [], @class, id, "body", styles);
