using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Logging.SeriLog;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.Exceptions.Handlers;
using Microsoft.AspNetCore.Http;
using Serilog.Context;
using System.Reflection;
using System.Security.Claims;
using System.Text.Json;
using System.Text.RegularExpressions;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly HttpExceptionHandler _httpExceptionHandler;

    private readonly FileLogger _fileLoggerService;
    private readonly MsSqlLogger _mssqlLoggerService;

    public ExceptionMiddleware(RequestDelegate next, FileLogger fileLoggerService, MsSqlLogger mssqlLoggerService)
    {
        _next = next;
        _httpExceptionHandler = new HttpExceptionHandler();
        _fileLoggerService = fileLoggerService;
        _mssqlLoggerService = mssqlLoggerService;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {
            await LogException(context, exception);
            await HandleExceptionAsync(context.Response, exception);
        }
    }

    private Task LogException(HttpContext context, Exception exception)
    {
        List<LogParameter> logParameters = new()
        {
            new LogParameter{
                Type=context.GetType().Name, 
                Value = exception.ToString()
            }
        };

        LogDetailWithException logDetail = new()
        {
            ExceptionMessage = exception.Message,
            MethodName = _next.Method.Name,
            Parameters = logParameters
        };
        var MethodName = context.Request.Path;
        var user = context.User;
        var username = user.Identity.IsAuthenticated ? user.Claims.FirstOrDefault(i => i.Type == ClaimTypes.Email)?.Value : "Unauthorized";

        LogContext.PushProperty("Username", username);
        LogContext.PushProperty("MethodName", MethodName);

        var options = new JsonSerializerOptions
        {
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true 
        };

        var serializedLogDetail = JsonSerializer.Serialize(logDetail,options);

        _fileLoggerService.Error(serializedLogDetail);
        _mssqlLoggerService.Error(serializedLogDetail);

        return Task.CompletedTask;
    }

    private Task HandleExceptionAsync(HttpResponse response, Exception exception)
    {
        response.ContentType = "application/json";
        _httpExceptionHandler.Response = response;
        return _httpExceptionHandler.HandleExceptionAsync(exception);
    }
}