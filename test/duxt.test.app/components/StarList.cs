using duxt.component;

namespace duxt.app.components;

public class StarList(List<string> items) : Component
{
    public override string Tag => "ul";
    public override string? Class => "list";
    public override List<IComponent>? Slot =>
        items.Select(item => new Li
        {
            Slot = [
                new Span
                {
                    Class = "list-star",
                    Slot = [new Text("★")]
                },
                new Text(item)
            ]
        }).ToList<IComponent>();
}