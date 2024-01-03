namespace Core.CrossCuttingConcerns.Exceptions.Handlers;

public abstract class ExceptionHandler
{
    public Task HandleExceptionAsync(Exception exception) =>
        exception switch
        {
            BusinessException businessException => HandleException(businessException)
            //ValidationException validationException => HandleException(validationException)
        };

    protected abstract Task HandleException(BusinessException businessException);
    //protected abstract Task HandleException(ValidationException validationException);
}