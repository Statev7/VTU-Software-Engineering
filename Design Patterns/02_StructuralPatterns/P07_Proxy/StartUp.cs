namespace P07_Proxy
{
    using System;

    using P07_Proxy.Models;
    using P07_Proxy.Models.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IBankAccount bankAccount = new BankAccountProxy();
            Client client = new Client("Pesho", bankAccount);
            try
            {
                client.BankAccount.DrawMoney(5);
                Console.WriteLine(client.BankAccount.GetBalance());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
