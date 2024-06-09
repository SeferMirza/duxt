using duxt.styles;

namespace duxt.component;

public class P(string text, string? @class = default, string? id = default, Styles? styles = default)
    : Component(new Text(text), new("p", @class, id), styles);
