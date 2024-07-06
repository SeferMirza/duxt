namespace duxt.component;

public class A(string href, string text)
    : Component
{
    public override string Tag { get; } = "a";

    public override string Display()
    {
        OtherProperties.Add("href", href);
        Slot?.Add(new Text(text));

        return base.Display();
    }
}
