var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => {

    //context.Response.StatusCode = 400;
    //context.Response.StatusCode = 500;
    if(1 == 1)
    {
        context.Response.StatusCode = 200;
    }
    else
    {
        context.Response.StatusCode = 400;
    }
    await context.Response.WriteAsync("Hello");
    await context.Response.WriteAsync("World");
   

});

app.Run();
