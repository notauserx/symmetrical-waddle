using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data;

public static class Setup
{
    public static IServiceCollection AddCarRentalsContext(this IServiceCollection services, string connectionString, string migrationAssembly)
    {
        services.AddDbContext<CarRentalsContext>(options =>
            options.UseSqlServer(
                connectionString,
                x => x.MigrationsAssembly(migrationAssembly)));

        return services;
    }
}
