namespace ERP1.Models.ValueObjects
{
    public class Document
    {
        public Document(string number)
        {
            this.Number = number;
        }
        public string Number {  get; set; }

        public override string ToString()
        {
            return Number;
        }
    }
}
