using Core.Exceptions.Handlers;
using Microsoft.AspNetCore.Http;


public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly HttpExceptionHandler _httpExceptionHandler;


    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
        _httpExceptionHandler = new HttpExceptionHandler();
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {
            //await LogException(context, exception);
            await HandleExceptionAsync(context.Response, exception);
        }
    }

    //private Task LogException(HttpContext context, Exception exception)
    //{
    //    List<LogParameter> logParameters = new()
    //    {
    //        new LogParameter{Type=context.GetType().Name, Value=exception.ToString()}
    //    };

    //    LogDetailWithException logDetail = new()
    //    {
    //        ExceptionMessage = exception.Message,
    //        MethodName = _next.Method.Name,
    //        Parameters = logParameters
    //    };

    //    _loggerService.Error(JsonSerializer.Serialize(logDetail));

    //    return Task.CompletedTask;
    //}

    private Task HandleExceptionAsync(HttpResponse response, Exception exception)
    {
        response.ContentType = "application/json";
        _httpExceptionHandler.Response = response;
        return _httpExceptionHandler.HandleExceptionAsync(exception);
    }
}