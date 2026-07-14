namespace ERP1.Models.ValueObjects
{
    public class Cpf
    {
        public Cpf(string number)
        {
            Number = number;
        }

        public string Number {  get; private set; }

        public override string ToString()
        {
            return Number;
        }
    }
}
