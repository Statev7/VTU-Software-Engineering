namespace P011_AbscraftFactory.Models
{
    public class ModernChair : Chair
    {
        private const decimal PRICE_VALUE = 75m;

        public ModernChair(string model) 
            : base(model, PRICE_VALUE)
        {

        }
    }
}
