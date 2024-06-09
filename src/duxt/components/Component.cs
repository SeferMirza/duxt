using duxt.styles;

namespace duxt.component;

public abstract class Component(List<Component> slot, Properties properties, Styles? styles)
{
    public List<Component> Slot { get; } = slot;
    public Properties Properties { get; } = properties;
    public Styles Styles { get; } = styles ?? new();

    public Component()
        : this([], new("div", default, default) , default) {}
    public Component(Component slot, Properties properties, Styles? styles = default)
        : this([slot], properties, styles) {}

    public virtual string Display()
    {
        var slotDisplays = Slot?.Select(s => s.Display());
        var slotDisplayString = slotDisplays != null ? string.Join("\n", slotDisplays) : string.Empty;
        var elementClass = Properties.Class != default ? $" class=\"{Properties.Class}\"" : string.Empty;
        var elementId = Properties.Id != default ? $" id=\"{Properties.Id}\"" : string.Empty;
        var stylesDisplay = styles != default ? $" style=\"{Styles.DisplayXDirection()}\"" : string.Empty;

        return @$"<{Properties.Tag}{elementClass}{elementId}{stylesDisplay}>
            {slotDisplayString}
            </{Properties.Tag}>".HtmlIndentation();
    }
}
