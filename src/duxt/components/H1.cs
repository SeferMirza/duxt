using duxt.styles;

namespace duxt.component;

public class H1(string text, string? @class = default, string? id = default, Styles? styles = default)
    : Component(new Text(text), @class, id, "h1", styles);
