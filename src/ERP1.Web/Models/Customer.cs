using ERP1.Models.ValueObjects;
using System.Linq;

namespace ERP1.Models
{
    public class Customer : Entity
    {
        private readonly List<Address> _addresses;

        private Customer() { }

        public Customer(string fullName, Cpf document, Email email, Phone phone)
        {
            FullName = fullName;
            Document = document;
            Email = email;
            Phone = phone;
            _addresses = new List<Address>();
        }
        
        public string FullName { get; private set; }
        public Cpf Document {  get; private set; }

        public Email Email { get; private set; }
        public Phone Phone {  get; private set; }
        public ICollection<Address> Addresses => _addresses.AsReadOnly();

        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return FullName;
        }

    }
}
