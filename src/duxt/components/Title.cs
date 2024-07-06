namespace duxt.component;

public class Title(string title) : Component
{
    public override string Tag { get; } = "title";
    public override List<IComponent>? Slot { get; set; } = [new Text(title)];
}
