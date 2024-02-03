using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middlware.MIddlwares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class PakistanMiddleware
    {
        private readonly RequestDelegate _next;

        public PakistanMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.ContentType = "text/html";
            await httpContext.Response.WriteAsync("asdfasdfasd Middleware");
            await _next(httpContext);
            await httpContext.Response.WriteAsync("end Middleware");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class PakistanMiddlewareExtensions
    {
        public static IApplicationBuilder UsePakistanMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PakistanMiddleware>();
        }
    }
}
