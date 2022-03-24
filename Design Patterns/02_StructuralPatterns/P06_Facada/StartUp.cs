namespace P06_Facada
{
    using System;

    using P06_Facada.Models;

    public class StartUp
    {
        public static void Main()
        {
            Order order = new Order();

            string orderResult = order.PlaceOrder("Phone", "PayPal", true);
            Console.WriteLine(orderResult);
        }
    }
}
