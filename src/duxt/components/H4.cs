using duxt.styles;

namespace duxt.component;

public class H4(string text, string? @class = default, string? id = default, Styles? styles = default)
    : Component(new Text(text), @class, id, "h4", styles);
