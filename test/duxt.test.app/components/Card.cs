using duxt.component;
using duxt.styles;

namespace duxt.app.components;

public class Card(string imgSrc, string title, string text, string link, Styles? styles = default)
    : Component(
        slot: [
                new Img(
                    @class: "card-img",
                    src: imgSrc
                ),
                new Div(
                    @class: "container",
                    slot: [
                        new H4(text: title),
                        new P(text: text),
                        new A(text: "Learn More", href: link, @class: "btn")
                    ]
                )
            ],
        @class: "card",
        id: default,
        tag: "div",
        styles: styles
    )
{ }
