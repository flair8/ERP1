namespace ERP1.Models.ValueObjects
{
    public class Phone
    {
        private Phone() { }
        public Phone(string number) 
        { 
            Number = number;  
        }

        public string Number { get; private set; }

        public override string ToString()
        {
            return Number;
        }
    }
}
