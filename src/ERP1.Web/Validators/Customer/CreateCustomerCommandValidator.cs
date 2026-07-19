using ERP1.Application.Customer;
using ERP1.Models.ValueObjects;
using FluentValidation;

namespace ERP1.Validators.Customer
{
    public sealed class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty()
                .WithMessage("Name is required.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress()
                .WithMessage("Email is invalid.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone is required.");

            RuleFor(x => x.Addresses)
                .NotEmpty().WithMessage("At least one address is required.");
            
            RuleFor(x => x.Document)
                .Must(Cpf.IsValid).WithMessage("Document must be valid.")
                .NotEmpty().WithMessage("Document is required.");
        }
    }
}
