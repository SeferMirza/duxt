namespace duxt.component;

public class Head(List<IComponent>? heads = default)
    : Component
{
    public override string Tag { get; } = "head";
    public override List<IComponent>? Slot { get; set; } = heads ?? [];

    public override string Display() =>
        base.Display();
}
