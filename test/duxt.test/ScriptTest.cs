using duxt.component;

namespace duxt.test;

[TestFixture]
public class ScriptTest
{
    class TestComponent : Component;
    class TestPage : IBodyContent
    {
        public IComponent Invoke(WebContext context, HttpClient client)
        {
            context.Scripts.Add("test.js");

            return new TestComponent();
        }
    }

    [Test]
    public void Given_script_paths_are_added_to_the_context()
    {
        var builder = Builder.CreateHtml();

        builder.AddBodySlot<TestPage>();

        Assert.That(builder.Context.Scripts.Scripts.Contains("test.js"));
    }

    [Test]
    public void Given_script_paths_are_generated_to_the_page()
    {
        var expected = "<script src=\"test.js\">";
        var builder = Builder.CreateHtml();
        builder.AddBodySlot<TestPage>();

        var actual = builder.DisplayPage<TestPage>();

        Assert.That(actual, Does.Contain(expected));
    }
}