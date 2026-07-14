using ERP1.Validators.Customer;
using FluentValidation;

namespace ERP1.Infrastructure
{
    public static class ValidatorConfiguration
    {
        public static IServiceCollection AddValidators(
            this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<CreateCustomerCommandValidator>();
            return services;
        }
    }
}
