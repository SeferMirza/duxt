using System.Xml.Linq;

namespace duxt;

public abstract class Component(List<Component> slot, string? @class, string? id, string? tag, Styles? styles)
{
    public List<Component> Slot { get; } = slot;
    public string? Class { get; } = @class;
    public string? Tag { get; } = tag;
    public string? Id { get; } = id;
    public Styles Styles { get; } = styles ?? new();

    public Component()
        : this([], default!, default!, default!, default) {}
    public Component(Component slot, string @class = "", string id = "", string tag = "div", Styles? styles = default)
        : this([slot], @class, id, tag, styles) {}
    public virtual string Display()
    {
        var slotDisplays = Slot?.Select(s => s.Display());
        var slotDisplayString = slotDisplays != null ? string.Join("\n", slotDisplays) : string.Empty;
        var elementClass = Class != default ? $"class=\"{Class}\"" : string.Empty;
        var elementId = Id != default ? $"id=\"{Id}\"" : string.Empty;
        var stylesDisplay = styles != default ? $"style=\"{Styles.DisplayXDirection()}\"" : string.Empty;

        return XElement.Parse(
            $"<{Tag} {elementClass} {elementId} {stylesDisplay}>" +
            slotDisplayString +
            $"</{Tag}>"
        ).ToString();
    }
}
