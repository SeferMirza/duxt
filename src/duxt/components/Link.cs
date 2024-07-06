namespace duxt.component;

public class Link(string href, string rel) : Component
{
    public override string Tag { get; } = "link";
    public override List<IComponent>? Slot { get; set; } = null;
    public override string Display()
    {
        OtherProperties.Add("href", href);
        OtherProperties.Add("rel", rel);

        return base.Display();
    }
}
