namespace P011_AbscraftFactory
{
    using P011_AbscraftFactory.Factories.Contracts;
    using P011_AbscraftFactory.Models.Contracts;

    public class Client
    {
        private readonly IFactory factory;

        public Client(IFactory factory)
        {
            this.factory = factory;
        }

        public IChair BuyChair(string model)
        {
            return this.factory.CreateChair(model);
        }

        public ICoffeTable BuyCoffeTable(double height, double width)
        {
            return this.factory.CreateCoffeTable(height, width);
        }
    }
}
