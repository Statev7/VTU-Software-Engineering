namespace P07_Proxy.Models
{
    using P07_Proxy.Models.Contracts;

    public class BankAccount : IBankAccount
    {
        public decimal Amount { get; private set; }

        public void DrawMoney(decimal amount)
        {
            this.Amount -= amount;
        }

        public void DepositMoney(decimal amount)
        {
            this.Amount += amount;
        }

        public decimal GetBalance()
        {
            return this.Amount;
        }
    }
}
