using Arca.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Arca.IoC;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddArcaServices(this IServiceCollection services, string connectionString)
    {
        services.AddInfrastructureServices(connectionString);
        return services;
    }

    private static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ArcaDbContext>(options => options.UseSqlite(connectionString));
        return services;
    }
}