namespace P07_Proxy.Models
{
    using System;

    using P07_Proxy.Models.Contracts;

    public class BankAccountProxy : IBankAccount
    {
        private readonly BankAccount bankAccount;

        public BankAccountProxy()
        {
            this.bankAccount = new BankAccount();
        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 10)
            {
                throw new ArgumentException("The minimum deposit is 10");
            }

            this.bankAccount.DepositMoney(amount);
        }

        public void DrawMoney(decimal amount)
        {
            if (this.bankAccount.Amount < amount)
            {
                throw new ArgumentException("You don't have enough balance");
            }

            this.bankAccount.DrawMoney(amount);
        }

        public decimal GetBalance()
        {
            return this.bankAccount.Amount;
        }
    }
}
