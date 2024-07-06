namespace duxt.component;

public class Meta(string? name = default, string? content = default, string? property = default)
    : Component
{
    public override string Tag { get; } = "meta";
    public override List<IComponent>? Slot { get; set; } = null;
    public override string Display()
    {
        if(name != null) OtherProperties.Add("name", name);
        if(content != null) OtherProperties.Add("name", content);
        if(property != null) OtherProperties.Add("name", property);

        return base.Display();
    }
}
