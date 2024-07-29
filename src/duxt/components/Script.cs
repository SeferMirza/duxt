namespace duxt.component;

public class Script : Component
{
    public override string Tag { get; } = "script";
    public override List<IComponent>? Slot { get; set; } = [];

    public override string Display()
    {
        var properties = string.Join(" ", OtherProperties.Select(s => $" {s.Key}=\"{s.Value}\""));
        return @$"<script{properties}></script>";
    }
}
