namespace P06_Facada.Factories
{
    using P06_Facada.Factories.Contracts;
    using P06_Facada.Models;

    public class ProductFactory : IFactory<Product>
    {
        public Product Create(object argument)
        {
            string name = argument.ToString();
            Product product = new Product(name);

            return product;
        }
    }
}
