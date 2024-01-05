using Core.CrossCuttingConcerns.Cache;
using Core.CrossCuttingConcerns.Logging.SeriLog;
using Microsoft.AspNetCore.Builder;

namespace Core.CrossCuttingConcerns.Exceptions.Extensions;

public static class ExceptionMiddlewareExtensions
{
    public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        => app.UseMiddleware<ExceptionMiddleware>().
        UseMiddleware<ValidationMiddleware>().
        UseMiddleware<CacheMiddleware>().
        UseMiddleware<SeriLogMiddleware>();
}