using duxt.component;
using duxt.styles;

namespace duxt.app.components;

public class Banner(string? title = default, Styles? styles = default)
    : Component(
        slot: [
            new H1(
                text: title ?? string.Empty,
                @class: "monospace"
            )
        ],
        new("div", "banner centered-content", default),
        styles
    );