namespace _02_BankApp.Factories
{
    using _02_BankApp.Implementation.Models;

    public class BankAccountFactory
    {
        public BankAccount Create(string fullName)
        {
            BankAccount bankAccount = new BankAccount(fullName);

            return bankAccount;
        }
    }
}
