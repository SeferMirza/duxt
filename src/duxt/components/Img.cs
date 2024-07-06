using duxt.styles;

namespace duxt.component;

public class Img(string src, string? alt = default, string? @class = default, string? id = default, Styles? styles = default)
    : Component()
{
    public override string Display()
    {
        var elementAlt = alt != default ? $" alt=\"{alt}\"" : string.Empty;
        var elementClass = @class != default ? $" class=\"{@class}\"" : string.Empty;
        var elementId = id != default ? $" id=\"{id}\"" : string.Empty;
        var elementStyles = styles != default ? $" style=\"{styles.DisplayXDirection()}\"" : string.Empty;

        return $"<img src=\"{src}\"{elementAlt}{elementClass}{elementId}{elementStyles}>";
    }
}
