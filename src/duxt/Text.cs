namespace duxt;

public class Text(string text)
    : Component()
{
    public override string Display()
    {
        return @$"{text}";
    }
}
