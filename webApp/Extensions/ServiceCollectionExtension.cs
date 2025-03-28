using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using webApp.UseCases;

namespace webApp.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        var connectionString =
            builder.Configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string"
                                                   + "'DefaultConnection' not found.");
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        builder.Services.AddScoped<IMouseTrackRepository, MouseTrackRepository>();
        builder.Services.AddScoped<ISaveMouseTracksUseCase, SaveMouseTracksUseCase>();
    }
}