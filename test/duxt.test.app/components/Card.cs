using duxt.component;
using duxt.styles;

namespace duxt.app.components;

public class Card(string cardTitle, string contentTitle, string text, string link, Styles? styles = default)
    : Component
{
    public override string Tag { get; } = "div";
    public override string? Class { get; set; } = "card";
    public override Styles? Styles { get; set; } = styles;
    public override List<IComponent>? Slot { get; set; } = [
        new H1(cardTitle)
        {
            Class = "card-title"
        },
        new Div
        {
            Class = "card-content-container",
            Slot = [
                new H4(text: contentTitle),
                new P(text: text),
                new A(text: "Learn More", href: link)
                {
                    Class = "btn"
                }
            ]
        }
    ];
}
