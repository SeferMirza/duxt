namespace duxt;

public static class ComponentExtensions
{
    public static Html Html(this Builder _, Head head, Body body, Dictionary<string, Styles>? styles = default) =>
        new(head, body, styles);
}
