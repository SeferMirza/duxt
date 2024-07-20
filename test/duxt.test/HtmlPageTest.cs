using duxt.component;
using duxt.exception;

namespace duxt.test;

[TestFixture]
public class HtmlPageTest
{
    class TestComponent : Component;

    class TestPage : IBodyContent
    {
        public IComponent Invoke(WebContext context)
        {
            return new TestComponent();
        }
    }

    [Test]
    public void HtmlPage_has_a_template_that_it_generates_by_default()
    {
        var expected = @"<html><head><title>Duxt</title></head><body><div></div></body><style></style></html>";
        var builder = Builder.CreateHtml();
        builder.AddBodySlot<TestPage>();

        var actual = builder.DisplayPage<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void If_registered_body_all_ready_exist_than_throw_error()
    {
        var builder = Builder.CreateHtml();
        builder.AddBodySlot<TestPage>();

        var bodyRegister = () => builder.AddBodySlot<TestPage>();

        Assert.That(bodyRegister, Throws.TypeOf<BodyContentExists<TestPage>>());
    }

    [Test]
    public void If_try_to_get_not_registered_body_than_throw_error()
    {
        var builder = Builder.CreateHtml();

        var bodyRegister = () => builder.DisplayPage<TestPage>();

        Assert.That(bodyRegister, Throws.TypeOf<PageNotExists<TestPage>>());
    }
}
