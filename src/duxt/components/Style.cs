using duxt.styles;

namespace duxt.component;

public class Style(StylesElement styles)
    : Component
{
    public override string Tag { get; } = "style";
    public override List<IComponent>? Slot { get; set; } = null;

    public override string Display()
    {
        return @$"<style>
                    {styles.HtmlView()}
                </style>";
    }
}
