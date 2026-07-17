using ERP1.Models.Enums;

namespace ERP1.Models
{
    public class Address : Entity
    {
        private Address() { }

        public Address(string street,
            string city,
            string number,
            string zipCode,
            string district,
            string state,
            string country,
            string complement,
            EAdressType adressType)
        {
            Street = street;
            City = city;
            Number = number;
            ZipCode = zipCode;
            District = district;
            State = state;
            Country = country;
            Complement = complement;
            AdressType = adressType;
        }

        public string Street { get; private set; }
        public string City { get; private set; }
        public string Number { get; private set; }
        public string ZipCode { get; private set; }
        public string District { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string Complement {  get; private set; }
        public EAdressType AdressType { get; private set; }

        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }

        public override string ToString()
        {
            return $"{Street} - {City} - {Number} - {ZipCode} - {Complement}";
        }
    }
}
