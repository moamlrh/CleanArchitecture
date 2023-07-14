

using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.Persistence;


public static class ServiceExtensions
{
    public static void ConfigureInfrastructureLayer(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddDbContext<ApplicationDbContext>(opts => opts.UseSqlServer("ConnectionStringHere"));
    }
}