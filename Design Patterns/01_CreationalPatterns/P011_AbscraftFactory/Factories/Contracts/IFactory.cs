namespace P011_AbscraftFactory.Factories.Contracts
{
    using P011_AbscraftFactory.Models.Contracts;

    public interface IFactory
    {
        IChair CreateChair(string model);

        ICoffeTable CreateCoffeTable(double height, double width);
    }
}
