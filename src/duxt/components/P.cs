namespace duxt.component;

public class P(string text)
    : Component
{
    public override string Tag { get;} = "p";
    public override List<IComponent>? Slot { get; set; } = [new Text(text)];
}
