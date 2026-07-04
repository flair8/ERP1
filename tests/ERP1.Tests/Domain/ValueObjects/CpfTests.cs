using ERP1.Controllers;
using ERP1.Models.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace ERP1.Tests.Domain.ValueObjects
{
    public class CpfTests
    {
        [Fact]
        public void Should_Create_Document_When_Valid()
        {
            var document = new Cpf("66338574030");

            Assert.Equal("66338574030", document.Number);
        }

        [Fact]
        public void Should_Remove_Document_Mask()
        {
            var document = new Cpf("66338574030");

            Assert.Equal("66338574030", document.Number);
        }

        [Fact]
        public void Should_Throw_Notification_When_Invalid_Document()
        {
            var document = new Cpf("66338574030");

            Assert.Equal("66338574030", document.Number);
        }

        [Fact]
        public void Should_Throw_Notification_When_Document_Empty()
        {
            var document = new Cpf("66338574030");

            Assert.Equal("66338574030", document.Number);
        }

        [Fact]
        public void Two_Documents_Should_Be_Equal()
        {
            var d1 = new Cpf("66338574030");
            var d2 = new Cpf("66338574030");

            Assert.Equal(d1.Number, d2.Number);
        }
    }
}
