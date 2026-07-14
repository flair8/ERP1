using ERP1.Application.Customer;
using ERP1.Configuration;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace ERP1.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencies(
            this IServiceCollection services)
        {
            services.AddSingleton<IEmailSender, EmailSender>();
            services.AddScoped<CreateCustomerCommandHandler>();
            return services;
        }
    }
}
