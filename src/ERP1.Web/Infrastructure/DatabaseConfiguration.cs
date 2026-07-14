using ERP1.Data;
using Microsoft.EntityFrameworkCore;

namespace ERP1.Infrastructure
{
    public static class DatabaseConfiguration
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("Default")));

            return services;
        }
    }
}
