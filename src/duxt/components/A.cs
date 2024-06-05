using duxt.styles;

namespace duxt.component;

public class A(string text, string href, string? @class = default, string? id = default, Styles? styles = default)
    : Component(new Text(text), @class, id, "a", styles)
{
    public override string Display() => @$"
        <a href=""{href}"" class=""{@class}"" id=""{id}"">{text}</a>
        ";
}
