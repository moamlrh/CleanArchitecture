
namespace CleanArchitecture.WebApi.Extensions;

public static class CorsPolicyExtensions
{
    public static void ConfigureCorsPolicy(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("Cors-Policy", builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
        });
    }
}