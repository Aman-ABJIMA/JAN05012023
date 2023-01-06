using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CustomMiddelware1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello 1 from new file\n");
            await next(context);
            await context.Response.WriteAsync("Hello 2 from new file\n");
        }
    }
}