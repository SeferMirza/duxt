namespace duxt.component;

public class Meta(params (string propertyName, string propertyValue)[] properties)
    : Component
{
    public override string Tag { get; } = "meta";
    public override List<IComponent>? Slot { get; set; } = null;
    public override string Display()
    {
        foreach(var (propertyName, propertyValue) in properties)
        {
            OtherProperties.TryAdd(propertyName, propertyValue);
        }

        return base.Display();
    }
}
