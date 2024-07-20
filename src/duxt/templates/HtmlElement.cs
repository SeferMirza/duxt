using duxt.component;

namespace duxt.templates;

public static class HtmlTemplates
{
    public static string SelfCloseElement(this IComponent component)
    {
        (string elementClass, string elementId, string stylesDisplay, string otherProperties) = component.ElementProperties();

        return @$"<{component.Tag}{elementClass}{elementId}{stylesDisplay}{otherProperties} />";
    }

    public static string VoidElement(this IComponent component)
    {
        (string elementClass, string elementId, string stylesDisplay, string otherProperties) = component.ElementProperties();

        return @$"<{component.Tag}{elementClass}{elementId}{stylesDisplay}{otherProperties}>";
    }

    public static string OpenCloseElement(this IComponent component)
    {
        var slot = component.Slot;
        if(slot == null) slot = [];

        var slotDisplays= slot.Select(s => s.Display());
        var slotDisplayString = slotDisplays.Any() ? string.Join("\n", slotDisplays) : string.Empty;
        (string elementClass, string elementId, string stylesDisplay, string otherProperties) = component.ElementProperties();

        return @$"<{component.Tag}{elementClass}{elementId}{stylesDisplay}{otherProperties}>
            {slotDisplayString}
        </{component.Tag}>";
    }

    private static (string @class, string id, string styles, string otherProperties) ElementProperties(this IComponent component)
    {
        var elementClass = component.Class != default
            ? $" class=\"{component.Class}\""
            : string.Empty;
        var elementId = component.Id != default
            ? $" id=\"{component.Id}\""
            : string.Empty;
        var stylesDisplay = component.Styles != default
            ? $" style=\"{component.Styles.DisplayXDirection()}\""
            : string.Empty;
        var otherProperties = component.OtherProperties != default
            ? string.Join(" ", component.OtherProperties.Select(s => $" {s.Key}=\"{s.Value}\""))
            : string.Empty;

        return (elementClass, elementId, stylesDisplay, otherProperties);
    }
}