using MediatR;
using CleanArchitecture.Application;
using CleanArchitecture.WebApi.Middlewares;
using CleanArchitecture.Infrastructure.Persistence;

namespace CleanArchitecture.WebApi;


public class Program
{
    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.ConfigureApplication();
        builder.Services.ConfigureInfrastructure();


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
