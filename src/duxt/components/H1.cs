using duxt.styles;

namespace duxt.component;

public class H1(string text, string? @class = default, string? id = default, Styles? styles = default)
    : Component(new Text(text), new("h1", @class, id), styles);
