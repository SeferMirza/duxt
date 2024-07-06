using duxt.styles;
using duxt.templates;

namespace duxt.component;

public abstract class Component : IComponent
{
    public virtual string Tag { get; } = "div";
    public virtual List<IComponent>? Slot { get; set; } = [];
    public virtual string? Class { get; set; } = default;
    public virtual string? Id { get; set; } = default;
    public virtual Styles? Styles { get; set; } = default;
    public virtual Dictionary<string, string> OtherProperties { get; set; } = [];

    public bool IsVoid =>
        Tag == "area" ||
        Tag == "base" ||
        Tag == "br" ||
        Tag == "col" ||
        Tag == "command" ||
        Tag == "embed" ||
        Tag == "hr" ||
        Tag == "img" ||
        Tag == "input" ||
        Tag == "keygen" ||
        Tag == "link" ||
        Tag == "meta" ||
        Tag == "param" ||
        Tag == "source" ||
        Tag == "track" ||
        Tag == "wbr";
    public bool IsSelfClose => !IsVoid && Slot == null;

    public virtual string Display()
    {
        string result;
        if (IsVoid) result = this.VoidElement();
        else if(IsSelfClose) result = this.SelfCloseElement();
        else result = this.OpenCloseElement();

        return result;
    }
}
