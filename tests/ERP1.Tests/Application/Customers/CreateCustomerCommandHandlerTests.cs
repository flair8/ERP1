using Bogus;
using ERP1.Application.Customer;
using ERP1.Data;
using ERP1.Repositories.Interfaces;
using ERP1.Validators.Customer;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP1.Tests.Application.Customers
{
    public class CreateCustomerCommandHandlerTests
    {
        private readonly Faker<CreateCustomerCommand> _customerFake;

        public CreateCustomerCommandHandlerTests()
        {
            _customerFake = new Faker<CreateCustomerCommand>()
                .RuleFor(user => user.FullName, faker => faker.Person.FirstName)
                .RuleFor(user => user.Email, (faker, user) => faker.Internet.Email(user.FullName))
                .RuleFor(user => user.Phone, faker => faker.Person.Phone)
                .RuleFor(user => user.Document, _ => "25748231093");
        }

        [Fact]
        public async Task Should_Create_Customer_When_Command_Is_Valid()
        {
            var customer = _customerFake.Generate();

            var handler = CreateHandler();

            var result = await handler.Handle(customer);
            
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public async Task Should_Return_Error_When_FullName_Is_Empty()
        {
            var customer = _customerFake.Generate();
            customer.FullName = "";

            var handler = CreateHandler();

            var result = await handler.Handle(customer);

            Assert.False(result.IsSuccess);
            Assert.Contains(result.Errors, e => e.Property == "FullName");
        }

        [Fact]
        public async Task Should_Return_Error_When_Email_Is_Invalid()
        {
            var customer = _customerFake.Generate();
            customer.Email = "dasdasda";

            var handler = CreateHandler();

            var result = await handler.Handle(customer);

            Assert.False(result.IsSuccess);
            Assert.Contains(result.Errors, e => e.Property == "Email");
        }

        [Fact]
        public async Task Should_Return_Error_When_Document_Is_Invalid()
        {
            var customer = _customerFake.Generate();
            customer.Document = "1231321312";

            var handler = CreateHandler();

            var result = await handler.Handle(customer);

            Assert.False(result.IsSuccess);
            Assert.Contains(result.Errors, e => e.Property == "Document");
        }

        public async Task Should_Return_Customer_When_Document_Is_Valid()
        {
            // validate document
        }

        private static CreateCustomerCommandHandler CreateHandler()
        {
            var validator = new CreateCustomerCommandValidator();
            var repository = new Mock<ICustomerRepository>();
            var unitOfWork = new Mock<IUnitOfWork>();

            return new CreateCustomerCommandHandler(validator, repository.Object, unitOfWork.Object);
        }
    }
}
