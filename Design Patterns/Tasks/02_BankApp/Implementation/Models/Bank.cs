namespace _02_BankApp.Implementation.Models
{
    using System.Collections.Generic;

    using _02_BankApp.Implementation.Contracts;
    using _02_BankApp.Implementation.Models.Abstraction;

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

        public void DrawLoan(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}
