using duxt.component;

namespace duxt.app.components;

public class Articles : Component
{
    public override string Tag { get; } = "div";
    public override string? Class { get; set; } = "articles-container centered-content column";
    public override List<IComponent>? Slot { get; set; } = [new H1("My Articles")];

    public override string Display()
    {
        Slot?.Add(new Text("It's empty for now."));

        return base.Display();
    }
}
