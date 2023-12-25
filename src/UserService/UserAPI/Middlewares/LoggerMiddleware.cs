using System.Text;

namespace UserAPI.Middlewares;

public class LoggerMiddleware(RequestDelegate next, ILogger<LoggerMiddleware> logger)
{
    private readonly RequestDelegate _next = next;
    private readonly ILogger<LoggerMiddleware> _logger = logger;

    public async Task InvokeAsync(HttpContext context)
    {
        LogRequest(context.Request);
        await _next(context);
        LogResponse(context.Response);
    }

    private void LogRequest(HttpRequest request)
    {
        var logBuilder = new StringBuilder();

        logBuilder.AppendLine("Incoming Request:");
        logBuilder.AppendLine($"Timestamp: {DateTime.UtcNow}");
        logBuilder.AppendLine($"Method: {request.Method}");
        logBuilder.AppendLine($"Path: {request.Path}");

        _logger.LogInformation(logBuilder.ToString());
    }

    private void LogResponse(HttpResponse response)
    {
        var logBuilder = new StringBuilder();

        logBuilder.AppendLine("Outgoing Response:");
        logBuilder.AppendLine($"Timestamp: {DateTime.UtcNow}");
        logBuilder.AppendLine($"Status Code: {response.StatusCode}");

        _logger.LogInformation(logBuilder.ToString());
    }
}