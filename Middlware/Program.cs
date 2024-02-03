using Middlware.MIddlwares;

var builder = WebApplication.CreateBuilder(args);
//======================================
//----------  Register Middlware ------------
//======================================
builder.Services.AddTransient<MyCustomMiddlware>();
var app = builder.Build();

//======================================
//------------  Middlware --------------
//======================================

//______ 1. Run Middlware ______
#region Run
//app.Run(async (HttpContext context) =>
//{
//    await context.Response.WriteAsync("My First Middlware");
//});
#endregion

//______ 2. Multiple Middlware (RequestDelegate) ______
#region by app.Use
//app.Use(async (HttpContext context, RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("My First Middlware");
//    await next(context);
//});

//app.Use(async (HttpContext context, RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("My 2nd Middlware");
//    await next(context);
//});

//app.Run(async (HttpContext context) =>
//{
//    await context.Response.WriteAsync("My 3rd Middlware");
//});
#endregion




app.Run();
