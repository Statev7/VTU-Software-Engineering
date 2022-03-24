namespace P06_Facada.Factories
{
    using P06_Facada.Factories.Contracts;
    using P06_Facada.Models;

    public class PaymentFactory : IFactory<Payment>
    {
        public Payment Create(object argument)
        {
            string type = argument.ToString();
            Payment payment = new Payment(type);

            return payment;
        }
    }
}
