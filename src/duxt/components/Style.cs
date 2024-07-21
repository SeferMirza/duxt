using duxt.styles;

namespace duxt.component;

public class Style(List<(string styleName, Styles styles)> styles)
    : Component
{
    public override string Tag { get; } = "style";
    public override List<IComponent>? Slot { get; set; } = null;

    public override string Display()
    {
        var stylesHtmlView = styles != default
            ? string.Join("\n", styles.Select(style =>
                @$"{style.styleName} {{
                {style.styles.DisplayYDirection()}
            }}"))
            : string.Empty;

        return @$"<style>
                    {stylesHtmlView}
                </style>";
    }
}
