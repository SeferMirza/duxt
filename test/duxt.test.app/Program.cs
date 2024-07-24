using duxt;
using duxt.app;
using duxt.app.services;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
var web = Builder.CreateHtml();
web.SetTitle("duxt");
web.AddLinks([
    new(href: "https://fonts.googleapis.com", rel: "preconnect"),
    new(href: "https://fonts.gstatic.com", rel: "preconnect"),
    new(href: "https://fonts.googleapis.com/css2?family=VT323&display=swap", rel: "stylesheet")
]);
web.AddMeta(new(properties: ("charset", "UTF8")));
web.AddGlobalStyles([
    CommonStyles.Body,
    CommonStyles.Content,
    CommonStyles.Font
]);

web.AddPages();

app.StaticFiles();

app.AddRoutes(web);

app.Run();
