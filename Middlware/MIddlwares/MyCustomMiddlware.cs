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
}
