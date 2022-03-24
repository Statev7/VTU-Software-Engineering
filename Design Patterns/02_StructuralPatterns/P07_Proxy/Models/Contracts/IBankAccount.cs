namespace P07_Proxy.Models.Contracts
{
    public interface IBankAccount
    {
        void DrawMoney(decimal amount);

        void DepositMoney(decimal amount);

        decimal GetBalance();
    }
}
