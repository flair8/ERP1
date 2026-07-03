using ERP1.Models.ValueObjects;
using System.Linq;

namespace ERP1.Models
{
    public class Customer : Entity
    {
        public Customer(string fullName, Document document, Email email, Phone phone)
        {
            FullName = fullName;
            Document = document;
            Email = email;
            Phone = phone;
            Address = new List<Address>();
        }

        public string FullName { get; private set; }
        public Document Document {  get; private set; }

        public Email Email { get; private set; }
        public Phone Phone {  get; private set; }
        public ICollection<Address> Address {  get; private set; }

        public void AddAddress(Address address)
        {
            //_addresses.Add(address);
        }

        public override string ToString()
        {
            return FullName;
        }

    }
}
