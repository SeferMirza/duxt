using duxt.styles;

namespace duxt.component;

public class H2(string text, string? @class = default, string? id = default, Styles? styles = default)
    : Component(new Text(text), new("h2", @class, id), styles);
