using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public RequestLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine($"[{DateTime.UtcNow}] Запрос: {context.Request.Method} {context.Request.Path}");
        await _next(context);
        Console.WriteLine($"[{DateTime.UtcNow}] Ответ: {context.Response.StatusCode}");
    }
}