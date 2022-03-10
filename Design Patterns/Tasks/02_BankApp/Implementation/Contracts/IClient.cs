namespace _02_BankApp.Implementation.Contracts
{
    using _02_BankApp.Implementation.Models;

    public interface IClient
    {
        string IdentificationNumber { get; }

        BankAccount BankAccount { get; }

        void AddLoan(Loan loan);
    }
}
