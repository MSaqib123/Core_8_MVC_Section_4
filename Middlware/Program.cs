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


//______ 3. (Code Managing) Custom Class Middlware  ______
#region 
////Custom Middwlare
//app.UseMiddleware<MyCustomMiddlware>();

////2nd middwlare
//app.Run(async (HttpContext context) =>
//{
//    await context.Response.WriteAsync("<br> My 3rd Middlware <br>");
//});
#endregion

//______ 4. Extension Method + Middlware ______
#region MyRegion
//Custom Middwlare
//app.UseMiddleware<MyCustomMiddlware>();
app.DoSomethingLikeUse();

//2nd middwlare
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("<br> My 3rd Middlware <br>");
});
#endregion

app.Run();
