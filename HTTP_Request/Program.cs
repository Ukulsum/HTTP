var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.Run( async (HttpContext context) =>
{
    string path = context.Request.Path;
    string method = context.Request.Method;

    context.Response.Headers["content-type"] = "text/html";
    await context.Response.WriteAsync($"<p>{path}</p>");
    await context.Response.WriteAsync($"<p>{method}</p>");

});

app.Run();
