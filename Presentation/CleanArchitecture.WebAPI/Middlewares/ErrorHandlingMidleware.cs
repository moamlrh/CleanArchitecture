using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;
using CleanArchitecture.Application.Common;
using CleanArchitecture.Domain.Errors;
using Microsoft.AspNetCore.Diagnostics;

namespace CleanArchitecture.WebApi.Middlewares;

public static class ErrorHandlingMidleware
{
    public static void UseExceptionHandlerMiddleware(this WebApplication app)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";
                var contextFeatures = context.Features.Get<IExceptionHandlerFeature>();

                if (contextFeatures != null)
                {
                    context.Response.StatusCode = contextFeatures.Error switch
                    {
                        NotFoundException => StatusCodes.Status404NotFound,
                        BadRequestException => StatusCodes.Status400BadRequest,
                        ValidationException => StatusCodes.Status422UnprocessableEntity, // you can replace it with your own validation exceptions class
                        _ => StatusCodes.Status500InternalServerError
                    };
                    if (contextFeatures.Error is ValidationException e)
                        await context.Response.WriteAsync(JsonSerializer.Serialize(new { e.Message }));
                    else
                    {
                        await context.Response.WriteAsync(new ErrorDetail(
                            context.Response.StatusCode,
                            contextFeatures.Error.Message).ToString());
                    }
                }
            });
        });
    }
}
