using JasperFx;

namespace Catalog.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PgConnection")!;
        
        services.AddMarten(connectionString)
                .UseLightweightSessions()
                .InitializeWith<InitializeDatabaseAsync>();
        
        return services;
    }
}
