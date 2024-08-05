using duxt;
using duxt.app;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
var web = Builder.CreateHtml();
web.AddLink(new(rel: "icon", href: "data:;base64,iVBORw0KGgo="));
web.AddLinks([
    new(rel: "preconnect", href: "https://fonts.googleapis.com"),
    new(rel: "preconnect", href: "https://fonts.gstatic.com")
    {
        OtherProperties = {{"crossorigin", string.Empty}}
    },
    new(href: "https://fonts.googleapis.com/css2?family=Ubuntu+Mono:ital,wght@0,400;0,700;1,400;1,700&family=VT323&display=swap", rel: "stylesheet")
]);
web.AddMeta(new(properties: ("charset", "UTF8")));
web.AddGlobalStyles(CommonStyles.GetAllStyles);

web.AddPages();

app.StaticFiles();

app.AddRoutes(web);

if(args.Contains("--ssg=true"))
{
    web.Publish();
}
else
{
    app.Run();
}
