namespace _01_LibraryApp.Factories
{
    using System;
    using System.Collections.Generic;

    using _01_LibraryApp.Models;

    public class BookFactory
    {
        private const string MANGA_TYPE_VALUE = "manga";
        private const string COMIC_TYPE_VALUE = "comic";

        private const string INVALID_BOOK_TYPE_ERROR_MESSAGE = "Invalid type!";

        public Book Create(List<string> arguments)
        {
            Book book = null;

            string type = arguments[0].ToLower();
            string name = arguments[1];
            string genre = arguments[2];

            switch (type)
            {
                case MANGA_TYPE_VALUE:
                    string authorFirstName = arguments[3];
                    book = new Manga(name, genre, authorFirstName);
                    break;
                case COMIC_TYPE_VALUE:
                    book = new Comic(name, genre);
                    break;

                default: throw new ArgumentException(INVALID_BOOK_TYPE_ERROR_MESSAGE);
            }

            return book;
        }
    }
}
