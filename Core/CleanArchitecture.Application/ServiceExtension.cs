using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application;

public static class ServiceExtensions
{
    public static void ConfigureApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(conf => conf.RegisterServicesFromAssembly(typeof(ServiceExtensions).Assembly));
    }
}