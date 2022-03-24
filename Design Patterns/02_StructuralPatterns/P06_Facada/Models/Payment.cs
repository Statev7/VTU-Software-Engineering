namespace P06_Facada.Models
{
    public class Payment
    {
        public Payment(string type)
        {
            this.Type = type;
        }

        public string Type { get; private set; }
    }
}
