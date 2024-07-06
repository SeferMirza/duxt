namespace duxt.component;

public class Text(string text)
    : Component
{
    public override string Tag => default!;

    public override string Display() => $"{text}";
}
