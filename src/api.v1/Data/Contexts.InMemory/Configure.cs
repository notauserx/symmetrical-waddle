using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data;

public static class Configure
{
    public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) => 
        services.AddDbContext<CarRentalsContext>(o => o.UseInMemoryDatabase("CarRentals"));
}