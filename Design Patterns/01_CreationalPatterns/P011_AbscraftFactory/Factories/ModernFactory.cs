namespace P011_AbscraftFactory.Factories
{
    using P011_AbscraftFactory.Factories.Contracts;
    using P011_AbscraftFactory.Models;
    using P011_AbscraftFactory.Models.Contracts;

    public class ModernFactory : IFactory
    {
        public IChair CreateChair(string model)
        {
            IChair chair = new ModernChair(model);

            return chair;
        }

        public ICoffeTable CreateCoffeTable(double height, double width)
        {
            ICoffeTable coffeTable = new ModernCoffeTable(height, width);

            return coffeTable;
        }
    }
}
