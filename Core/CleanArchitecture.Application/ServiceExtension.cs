using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}