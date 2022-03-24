namespace P07_Proxy.Models
{
    using P07_Proxy.Models.Contracts;

    public class Client
    {
        public Client(string name, IBankAccount bankAccount)
        {
            this.Name = name;
            this.BankAccount = bankAccount;
        }

        public string Name { get; private set; }

        public IBankAccount BankAccount { get; private set; }
    }
}
