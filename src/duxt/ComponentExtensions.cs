namespace duxt;

public static class ComponentExtensions
{
    public static Html Html(this Builder _, Head head, Body body) => new(head, body);
}
