using duxt.component;

namespace duxt.test;

[TestFixture]
public class StyleTest
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
            context.Styles.Add([
              (".duxtTest", new(){ Color = "red" }),
              ("div", new(){ BackgroundColor = "red", TextDecoration = "none" })
            ]);

            return new TestComponent();
        }
    }

    [Test]
    public void Global_style_generation()
    {
        Assert.Fail("not imp.");
    }
}
