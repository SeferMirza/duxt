namespace duxt.component;

public class H2(string text)
    : Component
{
    public override string Tag { get; } = "h2";
    public override List<IComponent>? Slot { get; set; } = [new Text(text)];
}