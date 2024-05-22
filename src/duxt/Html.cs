namespace duxt;

public class Html(Component? slot = default, string? @class = default, string? id = default, Styles? styles = default)
    : Component(slot, @class, id, "Html", styles);
