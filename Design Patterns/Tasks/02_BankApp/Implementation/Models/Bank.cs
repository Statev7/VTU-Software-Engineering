namespace _02_BankApp.Implementation.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using _02_BankApp.Implementation.Contracts;
    using _02_BankApp.Implementation.Models.Abstraction;
    using _02_BankApp.Utilities.Constants.Models;

    public class Bank : BaseModel
    {
        private readonly ICollection<IClient> clients;

        public Bank(string name, decimal balance)
            :base()
        {
            this.Name = name;
            this.Balance = balance;
            this.clients = new HashSet<IClient>();
        }

        public string Name { get; private set; }

        public decimal Balance { get; private set; }

        public IReadOnlyCollection<IClient> Clients => (IReadOnlyCollection<IClient>)this.clients;

        public void AddClient(IClient client)
        {
            this.clients.Add(client);
        }

        public decimal DrawLoan(IClient client, decimal amount)
        {
            decimal loan = CalculateLoan(client, amount);
            this.Balance -= amount;

            return loan;
        }

        public IClient FindClientByIdentificationNumber(string identificationNumber)
        {
            IClient client = this.Clients.SingleOrDefault(c => c.IdentificationNumber == identificationNumber);

            return client;
        }

        private decimal CalculateLoan(IClient client, decimal loanAmount)
        {
            double rate = 0;

            switch (client.BankAccount.Type)
            {
                case Enumerators.AccountType.Regular:
                    rate = LoanConstants.REGULAR_RATE_VALUE;
                    break;
                case Enumerators.AccountType.Bronze:
                    rate = LoanConstants.BRONZE_RATE_VALUE;
                    break;
                case Enumerators.AccountType.Gold:
                    rate = LoanConstants.GOLD_RATE_VALUE;
                    break;
                case Enumerators.AccountType.Platinum:
                    rate = LoanConstants.PLATINUM_RATE_VALUE;
                    break;
            }

            decimal loan = (loanAmount * (decimal)rate) + loanAmount;
            return loan;
        }
    }
}
