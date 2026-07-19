using System.Text.RegularExpressions;

namespace ERP1.Models.ValueObjects
{
    public class Cpf
    {
        private Cpf() { }

        public Cpf(string number)
        {
            Number = Regex.Replace(number, @"\D", "");
        }

        public string Number {  get; private set; }

        public static bool IsValid(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            cpf = Regex.Replace(cpf, @"\D", "");

            return cpf.Length == 11;
        }

        public override string ToString()
        {
            return Number;
        }
    }
}
