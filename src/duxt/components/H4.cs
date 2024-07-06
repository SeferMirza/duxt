namespace duxt.component;

public class H4(string text)
    : Component
{
    public override string Tag { get; } = "h4";
    public override List<IComponent>? Slot { get; set; } = [new Text(text)];
}
