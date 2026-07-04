namespace ERP1.Models.ValueObjects
{
    public class Phone
    {
        public Phone(string number) 
        { 
            Number = number;  
        }

        public string Number { get; set; }

        public override string ToString()
        {
            return Number;
        }
    }
}
