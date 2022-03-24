namespace P06_Facada.Models
{
    public class Product
    {
        public Product(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
