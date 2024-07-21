using duxt.component;

namespace duxt.test;

[TestFixture]
public class StyleGenerationTest
{
    class TestComponent : Component
    {
        public override string Display()
        {
            return "";
        }
    }

    class TestPage : IBodyContent
    {
        public IComponent Invoke(WebContext context)
        {
            context.Styles.AddRange([
              (".duxtTest", new(){ Color = "red" }),
              ("div", new(){ BackgroundColor = "red", TextDecoration = "none" })
            ]);

            return new TestComponent();
        }
    }

    [Test]
    public void Global_style_generation()
    {
        var expected = @"<html><head><title>Duxt</title></head><body></body><style>.duxtTest { color: red; } div { background-color: red; text-decoration: none; }</style></html>";
        var builder = Builder.CreateHtml();
        builder.AddBodySlot<TestPage>();

        var actual = builder.DisplayPage<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [Ignore("tbd")]
    public void Element_style_generation()
    {
        // TBD
    }
}
