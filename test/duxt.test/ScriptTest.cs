using duxt.component;

namespace duxt.test;

[TestFixture]
public class ScriptTest
{
    class TestComponent : Component;
    class TestPage : IBodyComponent
    {
        public Component Invoke(HtmlContext context)
        {
            context.Scripts.Add("test.js");

            return new TestComponent();
        }
    }

    [Test]
    public void Given_script_paths_are_added_to_the_context()
    {
        var builder = Builder.CreateHtml();

        builder.Slot<TestPage>();

        Assert.That(builder.Context.Scripts.Scripts.Contains("test.js"));
    }

    [Test]
    public void Given_script_paths_are_generated_to_the_page()
    {
        var expected = "<script src=\"test.js\">";
        var builder = Builder.CreateHtml();

        string page = builder.Slot<TestPage>();

        Assert.That(page.Contains(expected));
    }
}