
namespace MiddleWareTutorial.ServicesCollectionExtensions;
public class CustomMiddleWare : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        await context.Response.WriteAsync("Hello from me");
    }
}
public static class ImplementMiddleWareExtensions
{
    public static IApplicationBuilder UseMiddleWare(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CustomMiddleWare>();
    }
}
