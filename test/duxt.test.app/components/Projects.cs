using duxt.component;

namespace duxt.app.components;

public class Projects : Component
{
    public override string Tag { get; } = "div";
    public override string? Class { get; set; } = "projects-container centered-content column";
    public override string? Id { get; set; } = "projects-container";
    public override List<IComponent>? Slot { get; set; } = [new H1("My Projects")];
}
