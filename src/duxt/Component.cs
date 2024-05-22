namespace duxt;

public abstract class Component(Component? slot, string @class = "", string id = "", string tag = "div", Styles? styles = default)
{
    public Component Slot { get; } = slot!;
    public string Class { get; } = @class;
    public string Tag { get; } = tag;
    public string Id { get; } = id;
    public Styles Styles { get; } = styles!;

    public virtual string Display()
    {
        return @$"
        <{Tag}>
            {Slot.Display()}
        </{Tag}>
        ";
    }
}
