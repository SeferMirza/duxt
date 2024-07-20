using duxt.component;

namespace duxt.test;

[TestFixture]
public class ComponentTest
{
    class TestComponent : Component
    {
        public override List<IComponent>? Slot { get; set; } = [
            new H1(text: "h1"),
            new H2(text: "h2"),
            new H4(text: "h4"),
            new A(href: "a href", text: "a text"),
            new Img(src: "src"),
            new P(text: "p")
        ];
    };

    class TestPage : IBodyContent
    {
        public IComponent Invoke(WebContext context)
        {
            context.Heads.Title = new(title: "title");
            context.Heads.Links.Add(new(href: "link href", rel: "link rel"));
            context.Heads.Metas.Add(new(name: "meta name", content: "meta content", property: "meta property"));

            return new TestComponent();
        }
    }

    [Test]
    public void All_default_component_display_correctly()
    {
        var expected = @"<html><head><title>title</title><link href=""link href"" rel=""link rel""><meta name=""meta name"" content=""meta content"" property=""meta property""></head><body><div><h1>h1</h1><h2>h2</h2><h4>h4</h4><a href=""a href"">a text</a><img src=""src""><p>p</p></div></body><style></style></html>";
        var builder = Builder.CreateHtml();
        builder.AddBodySlot<TestPage>();

        var actual = builder.DisplayPage<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }
}