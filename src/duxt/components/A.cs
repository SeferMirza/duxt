using duxt.styles;

namespace duxt.component;

public class A(string text, string href, string? @class = default, string? id = default, Styles? styles = default)
    : Component(new Text(text), new("a", @class, id), styles)
{
    public override string Display() => @$"
        <a href=""{href}"" class=""{Properties.Class}"" id=""{Properties.Id}"">{text}</a>
        ";
}
