namespace P011_AbscraftFactory.Models
{
    public class VictorianCoffeTable : CoffeTable
    {
        private const string COLOR_VALUE = "Black";

        public VictorianCoffeTable(double height, double width) 
            : base(height, width, COLOR_VALUE)
        {

        }
    }
}
