namespace duxt;

public class Text(string text, string? @class = default)
    : Component()
{
    public override string Display()
    {
        return @$"
            {text}
        ";
    }
}
