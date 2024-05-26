using duxt.app.pages;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(Profile.Page, "text/html"));

app.Run();
