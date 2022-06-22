using Microsoft.AspNetCore.Diagnostics;
using System.Text.Json;
using System.Net;
using System.ComponentModel.DataAnnotations;
using ErrorProcessingWeb.Models.VM;

namespace ErrorProcessingWeb.Extensions;

public static class ExceptionMiddlewareExtensions
{
    public static void UseCustomExceptionHandler(this IApplicationBuilder app) =>
        app.UseExceptionHandler(new ExceptionHandlerOptions() { ExceptionHandler = ExceptionHandler });

    static async Task ExceptionHandler(HttpContext context)
    {
        var exceptionFeature = context.Features.Get<IExceptionHandlerFeature>();
        if (exceptionFeature != null)
        {
            //извлечь из InnerException (если есть) известные нам типы исключений
            var exception = GetWellKnownException(exceptionFeature.Error);

            //подготовить ответ
            (HttpStatusCode errorCode, object errorObj) = exception switch
            {
                ValidationException ex => ProcessValidationException(ex),
                AggregateException ex => ProcessAggregateException(ex),
                //...
                _ => (HttpStatusCode.InternalServerError, new InternalServerErrorVM() {
                    Message = exception.Message,
                    Type = exception.GetType().ToString()
                })
            };

            //записать в лог
            //...

            //вернуть json с описанием ошибки и соответствующим кодом
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)errorCode;
            await context.Response.WriteAsync(JsonSerializer.Serialize(errorObj));
        }
    }

    static (HttpStatusCode, object) ProcessValidationException (ValidationException ex)
    {
        //...
        return (HttpStatusCode.BadRequest, new {} );
    }

    static (HttpStatusCode, object) ProcessAggregateException (AggregateException ex)
    {
        //Flatten
        //...
        return (HttpStatusCode.BadRequest, new {} );
    }

    static Exception GetWellKnownException(Exception rootException)
    {
        var processingException = rootException;
        
        //переходить к InnerException, пока не найдем известный тип исключения или не доберемся до конца цепочки
        while(processingException is not null        
            and not ValidationException
            and not AggregateException
            //...
        )
            processingException = processingException.InnerException;

        return processingException ?? rootException;
    }
}
