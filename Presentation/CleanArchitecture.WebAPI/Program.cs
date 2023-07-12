using MediatR;
using CleanArchitecture.Application.Features;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Infrastructure.Persistence.Repositories;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using CleanArchitecture.WebApi.Middlewares;

namespace CleanArchitecture.WebApi;


public class Program
{
    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


        builder.Services.AddMediatR(c => c.RegisterServicesFromAssembly(typeof(CreateUserHandler).Assembly));
        builder.Services.AddAutoMapper(typeof(CreateUserMapper).Assembly);
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddDbContext<ApplicationDbContext>(opts => opts.UseSqlServer("ConnectionStringHere"));


        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseExceptionHandlerMiddleware();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
