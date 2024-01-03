﻿using Core.CrossCuttingConcerns.Exceptions.Extensions;
using Core.CrossCuttingConcerns.Exceptions.Handlers;
using Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;
using Microsoft.AspNetCore.Http;
//using ValidationProblemDetails = Core.Exceptions.HttpProblemDetails.ValidationProblemDetails;

namespace Core.Exceptions.Handlers;
public class HttpExceptionHandler : ExceptionHandler
{
    private HttpResponse? _response;
    public HttpResponse Response
    {
        get => _response ?? throw new ArgumentNullException(nameof(_response));
        set => _response = value;
    }
    protected override Task HandleException(BusinessException businessException)
    {
        Response.StatusCode = StatusCodes.Status400BadRequest;
        string details = new BusinessProblemDetails(businessException.Message).AsJson();
        return Response.WriteAsync(details);
    }
    //protected override Task HandleException(ValidationException validationException)
    //{
    //    Response.StatusCode = StatusCodes.Status400BadRequest;
    //    string details = new ValidationProblemDetails(validationException.Errors).AsJson();
    //    return Response.WriteAsync(details);
    //}
}