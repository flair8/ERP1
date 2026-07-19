using ERP1.Data;
using ERP1.Models;
using ERP1.Models.ValueObjects;
using ERP1.Repositories.Interfaces;
using FluentValidation;

namespace ERP1.Application.Customer
{
    public class CreateCustomerCommandHandler
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IValidator<CreateCustomerCommand> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCustomerCommandHandler(
            IValidator<CreateCustomerCommand> validator,
            ICustomerRepository customerRepository,
            IUnitOfWork unitOfWork)
        {
            _validator = validator;
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
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

            foreach (var addressCommand in command.Addresses)
            {
                var address = new Address(
                    addressCommand.Street,
                    addressCommand.City,
                    addressCommand.Number,
                    addressCommand.ZipCode,
                    addressCommand.District,
                    addressCommand.State,
                    addressCommand.Country, addressCommand.Complement, addressCommand.AdressType);

                customer.AddAddress(address);
            }

            await _customerRepository.AddAsync(customer);
            await _unitOfWork.CommitAsync();

            return Result.Success();
        }
    }
}
