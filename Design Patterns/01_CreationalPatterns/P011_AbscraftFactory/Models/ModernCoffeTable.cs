namespace P011_AbscraftFactory.Models
{
    public class ModernCoffeTable : CoffeTable
    {
        private const string COLOR_VALUE = "White";

        public ModernCoffeTable(double height, double width)
            : base(height, width, COLOR_VALUE)
        {

        }
    }
}
