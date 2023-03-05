using Dishes.Infra.Context;
using Dishes.Domain.Interfaces;
using Dishes.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dishes.Infra;

public static class DependencyInjection
{
    public static IServiceCollection AddServicesInfra(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IDishRepository, DishRepository>();
        services.AddTransient<ICategoryRepository, CategoryRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();

        services.AddDbContext<DishesDBContext>(
            options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
        );

        return services;
    }
}