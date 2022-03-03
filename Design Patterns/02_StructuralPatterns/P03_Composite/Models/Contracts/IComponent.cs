namespace P03_Composite.Models.Contracts
{
    public interface IComponent
    {
        public string FirstName { get; }

        string DisplayEmployee();
    }
}
