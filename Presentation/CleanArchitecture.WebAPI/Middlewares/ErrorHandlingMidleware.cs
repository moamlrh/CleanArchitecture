using System.Net;
using CleanArchitecture.Domain.Errors;
using Microsoft.AspNetCore.Diagnostics;
using CleanArchitecture.Application.Common.Exceptions;

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
                        _ => StatusCodes.Status500InternalServerError
                    };

                    var response = new ErrorDetail(
                        context.Response.StatusCode,
                        contextFeatures.Error.Message
                    );

                    await context.Response.WriteAsync(response.ToString());
                }
            });
        });
    }
}
