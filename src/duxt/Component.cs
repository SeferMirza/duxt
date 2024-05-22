namespace duxt;

public abstract class Component(Component slot, string @class, string id, Styles styles)
{
    public Component Slot { get; } = slot;
    public string Class { get; } = @class;
    public string Id { get; } = id;
    public Styles Styles { get; } = styles;

    public virtual string Display()
    {
        return string.Empty;
    }
}
