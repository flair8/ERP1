using ERP1.Models;
using ERP1.Models.ValueObjects;
using FluentValidation;
using System.Reflection.Metadata;

namespace ERP1.Application.Customer
{
    public class CreateCustomerCommandHandler
    {
        private readonly IValidator<CreateCustomerCommand> _validator;

        public CreateCustomerCommandHandler(IValidator<CreateCustomerCommand> validator)
        {
            _validator = validator;
        }

        public async Task<Result> Handle(CreateCustomerCommand command)
        {
            var result = new Result();

            var validation = await _validator.ValidateAsync(command);

            if (!validation.IsValid)
            {
                foreach (var error in validation.Errors)
                {
                    result.AddError(error.PropertyName, error.ErrorMessage);
                }

                return result;
            }

            var customer = new Models.Customer(
                fullName: command.FullName,
                document: new Models.ValueObjects.Cpf(command.Document),
                email: new Email(command.Email),
                phone: new Phone(command.Phone)
            );

            // UnitOfWork

            return Result.Success();
        }
    }
}
