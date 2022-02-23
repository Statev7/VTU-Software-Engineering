namespace _01_LibraryApp.Models
{
    public abstract class Book
    {
        protected Book(string name, string genre)
        {
            this.Name = name;
            this.Genre = genre;
        }

        public string Name { get; set; }

        public string Genre { get; set; }

        public Book ShallowCopy()
        {
            return (Book)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}, Name: {this.Name}, Genre: {this.Genre}";
        }
    }
}
