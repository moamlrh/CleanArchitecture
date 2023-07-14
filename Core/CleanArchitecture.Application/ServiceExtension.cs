using System.Reflection;
using MediatR;
using CleanArchitecture.Application.Common.Behaviors;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application;

public static class ServiceExtensions
{
    public static void ConfigureApplicationLayer(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));
        services.AddMediatR(conf => conf.RegisterServicesFromAssembly(typeof(ServiceExtensions).Assembly));
    }
}