namespace duxt.component;

public class H1(string text) : Component
{
    public override string Tag { get; } = "h1";
    public override List<IComponent>? Slot { get; set; } = [new Text(text)];
}
