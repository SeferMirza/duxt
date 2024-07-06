using duxt.styles;

namespace duxt.component;

public interface IComponent
{
    public string Tag { get; }
    public List<IComponent>? Slot { get; }
    public string? Class { get; set; }
    public string? Id { get; set; }
    public Styles? Styles { get; set; }
    public Dictionary<string, string> OtherProperties { get; set; }
    public bool IsVoid { get; }
    public bool IsSelfClose { get; }

    public string Display();
}
