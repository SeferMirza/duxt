using duxt.component;

namespace duxt.test;

[TestFixture]
public class ScriptTest
{
    class TestComponent : Component;
    class TestPage : IBodyContent
    {
        public IComponent Invoke(WebContext context)
        {
            context.Scripts.Add(new Script("test.js"));

            return new TestComponent();
        }
    }

    [Test]
    public void Given_script_paths_are_added_to_the_context()
    {
        var builder = Builder.CreateHtml();

        builder.AddBodySlot<TestPage>();

        Assert.That(
            builder.Context.Scripts.Any(script =>
                {
                    script.OtherProperties.TryGetValue("src", out var path);
                    return path == "test.js";
                }
            )
        );
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

    [Test]
    public void Given_script_path_is_added_to_context()
    {
        var script = new Script("test path");
        var builder = Builder.CreateHtml();

        builder.AddScript(script);

        Assert.That(builder.Context.Scripts.Count, Is.EqualTo(1));
        Assert.That(builder.Context.Scripts, Does.Contain(script));
    }

    [Test]
    public void Given_script_paths_are_added_to_context()
    {
        var script1 = new Script("test path 1");
        var script2 = new Script("test path 2");
        var builder = Builder.CreateHtml();

        builder.AddScripts([script1, script2]);

        Assert.That(builder.Context.Scripts.Count, Is.EqualTo(2));
    }
}