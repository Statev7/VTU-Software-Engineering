namespace P06_Facada.Models
{
    using P06_Facada.Factories;
    using P06_Facada.Factories.Contracts;

    public class Order
    {
        private readonly IFactory<Product> productFactory;
        private readonly IFactory<Payment> paymentFactory;

        public Order()
        {
            this.productFactory = new ProductFactory();
            this.paymentFactory = new PaymentFactory();
        }

        public string PlaceOrder(string productName, string paymentType, bool invoiceOption)
        {
            Product product = this.productFactory.Create(productName);
            Payment payment = this.paymentFactory.Create(paymentType);
            string invoceMessage = invoiceOption == false ? "no" : "yes";

            return $"You have successfuly ordered {product.Name}.Payment type {payment.Type}.Invoice: {invoceMessage}";
        }
    }
}
