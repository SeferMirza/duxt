using duxt.styles;

namespace duxt.component;

public class P(string text, string? @class = default, string? id = default, Styles? styles = default)
    : Component(new Text(text), @class, id, "P", styles);
