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

    class TestPage : IBodyContent
    {
        public IComponent Invoke(HtmlContext context, HttpClient client) => new EmptyComponent();
    }

    [Test]
    public void Generate_links_as_void_element_when_given_list()
    {
        var expected =
@"<html>
  <head>
    <title>
      Duxt
    </title>
    <link href=""styles1.css"" rel=""stylesheet"">
    <link href=""styles2.css"" rel=""stylesheet"">
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
                headElement.Links.AddRange([new("styles1.css", "stylesheet"), new("styles2.css", "stylesheet")]));
        var actual = builder.Slot<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Generate_links_as_void_element_when_given_single_link()
    {
        var expected =
@"<html>
  <head>
    <title>
      Duxt
    </title>
    <link href=""styles1.css"" rel=""stylesheet"">
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
                headElement.Links.Add(new("styles1.css", "stylesheet")));
        var actual = builder.Slot<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Generate_metas_as_void_element_when_given_single()
    {
        var expected =
@"<html>
  <head>
    <title>
      Duxt
    </title>
    <meta name=""og"" content=""duxt"" property=""og:title"">
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
                headElement.Metas.Add(new(name: "og", property: "og:title", content: "duxt")));
        var actual = builder.Slot<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Generate_metas_as_void_element_when_given_list()
    {
        var expected =
@"<html>
  <head>
    <title>
      Duxt
    </title>
    <meta name=""og"" content=""duxt"" property=""og:title"">
    <meta name=""og"" content=""someimage.com"" property=""og:image"">
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
                headElement.Metas.AddRange([new("og", "duxt", "og:title"), new("og", "someimage.com", "og:image")]));
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
            .Head(headElement => headElement.Title = new("duxt"));
        var actual = builder.Slot<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }
}