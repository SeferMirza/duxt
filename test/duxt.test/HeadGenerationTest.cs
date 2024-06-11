using duxt.component;

namespace duxt.test;

[TestFixture]
public class HeadGenerationTest
{
    class EmptyComponent
    : Component
    {
        public override string Display() => string.Empty;
    }

    class TestPage : IBodyComponent
    {
        public Component Invoke(HtmlContext context) => new EmptyComponent();
    }

    [Test]
    public void Generate_links_as_void_element_when_given_list()
    {
        var expected =
@"<html>
  <head>
    <link rel=""stylesheet"" href=""styles1.css"">
    <link rel=""stylesheet"" href=""styles2.css"">
  </head>
  <body>
  </body>
  <style>
  </style>
</html>
";

        var builder = Builder
            .CreateHtml()
            .Head(headElement =>
                headElement.Links.Add([("style1.css", "stylesheet"), ("style2.css", "stylesheet")]));
        var actual = builder.Slot<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Generate_links_as_void_element_when_given_single_link()
    {
        var expected =
@"<html>
  <head>
    <link rel=""stylesheet"" href=""styles1.css"">
  </head>
  <body>
  </body>
  <style>
  </style>
</html>
";

        var builder = Builder
            .CreateHtml()
            .Head(headElement =>
                headElement.Links.Add("style1.css", "stylesheet"));
        var actual = builder.Slot<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Generate_metas_as_void_element_when_given_single()
    {
        var expected =
@"<html>
  <head>
    <meta name="""" content=""duxt"" property=""og:title"">
  </head>
  <body>
  </body>
  <style>
  </style>
</html>
";

        var builder = Builder
            .CreateHtml()
            .Head(headElement =>
                headElement.Metas.Add("og:title", "duxt"));
        var actual = builder.Slot<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Generate_metas_as_void_element_when_given_list()
    {
        var expected =
@"<html>
  <head>
    <meta name="""" content=""duxt"" property=""og:title"">
    <meta name="""" content=""someimage.com"" property=""og:image"">
  </head>
  <body>
  </body>
  <style>
  </style>
</html>
";

        var builder = Builder
            .CreateHtml()
            .Head(headElement =>
                headElement.Metas.Add([("og", "duxt", "og:title"), ("og", "someimage.com", "og:image")]));
        var actual = builder.Slot<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Generate_title_as_open_close_element_when_given_list()
    {
        var expected =
@"<html>
  <head>
    <title>
      duxt
    </title>
  </head>
  <body>
  </body>
  <style>
  </style>
</html>
";

        var builder = Builder
            .CreateHtml()
            .Head(headElement => headElement.Title = "duxt");
        var actual = builder.Slot<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }
}