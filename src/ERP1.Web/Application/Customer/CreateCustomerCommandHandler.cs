using ERP1.Models;
using ERP1.Models.ValueObjects;
using System.Reflection.Metadata;

namespace ERP1.Application.Customer
{
    public class CreateCustomerCommandHandler
    {
        public async Task<Result> Handle(CreateCustomerCommand command)
        {
            var customer = new Models.Customer(
                fullName: command.FullName,
                document: new Models.ValueObjects.Document(command.Document),
                email: new Email(command.Email),
                phone: new Phone(command.Phone)
            );

            // repository
            // UnitOfWork

            return Result.Success();
        }
    }
}
