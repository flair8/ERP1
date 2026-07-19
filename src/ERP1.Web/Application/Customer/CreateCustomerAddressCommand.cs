using ERP1.Models.Enums;

namespace ERP1.Application.Customer
{
    public class CreateCustomerAddressCommand
    {
        public string Street { get; private set; } = string.Empty;
        public string City { get; private set; } = string.Empty;
        public string Number { get; private set; } = string.Empty;
        public string ZipCode { get; private set; } = string.Empty;
        public string District { get; private set; } = string.Empty;
        public string State { get; private set; } = string.Empty;
        public string Country { get; private set; } = string.Empty;
        public string Complement { get; private set; } = string.Empty;
        public EAdressType AdressType { get; private set; }
    }
}
