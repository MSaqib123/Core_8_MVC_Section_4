var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//======================================
//------------  Middlware --------------
//======================================

//______ 1. Run Middlware ______
#region Run
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("My First Middlware");
});
#endregion

app.Run();
