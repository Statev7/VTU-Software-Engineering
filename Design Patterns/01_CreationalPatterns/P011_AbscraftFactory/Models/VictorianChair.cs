namespace P011_AbscraftFactory.Models
{
    public class VictorianChair : Chair
    {
        private const decimal PRICE_VALUE = 50m;

        public VictorianChair(string model) 
            : base(model, PRICE_VALUE)
        {

        }
    }
}
