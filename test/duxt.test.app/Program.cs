using duxt;
using duxt.app;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
var web = Builder.CreateHtml();
web.AddLink(new(rel: "icon", href: "data:;base64,iVBORw0KGgo="));
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
