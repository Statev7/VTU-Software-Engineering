namespace _02_BankApp.Factories
{
    using System.Collections.Generic;

    using _02_BankApp.Implementation.Models;

    public class ClientFactory
    {
        public Client Create(List<object> arguments)
        {
            string firstName = arguments[0].ToString();
            string lastName = arguments[1].ToString();
            string identificationNumber = arguments[2].ToString();
            BankAccount bankAccount = arguments[3] as BankAccount;

            Client client = new Client(firstName, lastName, identificationNumber, bankAccount);
            return client;
        }
    }
}
