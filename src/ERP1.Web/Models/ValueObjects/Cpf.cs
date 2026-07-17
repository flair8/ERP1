using System.Text.RegularExpressions;

namespace ERP1.Models.ValueObjects
{
    public class Cpf
    {
        private Cpf() { }

        public Cpf(string number)
        {
            Number = Regex.Replace(number, @"\D", "");
            // add later notification
            if (Number.Length != 11)
                throw new ArgumentException("CPF inválido");
        }

        public string Number {  get; private set; }

        public override string ToString()
        {
            return Number;
        }
    }
}
