namespace Middlware.MIddlwares
{
    //__________ 1st Way to create Middlware ____________
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

    //__________ 2nd way to create middlware ____________
    //without Inhariting IMiddlware interface 

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
