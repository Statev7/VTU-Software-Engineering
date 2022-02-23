namespace _01_LibraryApp.Models
{
    public class Manga : Book
    {
        public Manga(string name, string genre, string authorFirstName) 
            : base(name, genre)
        {
            this.AuthorFirstName = authorFirstName;
        }

        public string AuthorFirstName { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Author: {this.AuthorFirstName}";
        }
    }
}
