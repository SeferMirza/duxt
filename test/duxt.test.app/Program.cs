using duxt.app;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(Pages.Index, "text/html"));

app.Run();
