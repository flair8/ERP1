using ERP1.Application.Customer;
using ERP1.Configuration;
using ERP1.Repositories;
using ERP1.Repositories.Interfaces;
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
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
