namespace Middlware.MIddlwares
{
    public class MyCustomMiddlware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            context.Response.ContentType = "text/html";
            await context.Response.WriteAsync("Start Middleware");
            await next(context);
            await context.Response.WriteAsync("end Middleware");
        }
    }

    public static class CustomMiddlewareExtension
    {
        //import this method in IApplicationClass
        //wo method jo Kisi interface/class me import ho ---> Extension method
        public static IApplicationBuilder DoSomethingLikeUse(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyCustomMiddlware>();
        }
    }
}
