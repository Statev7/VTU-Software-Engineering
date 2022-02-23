namespace _01_LibraryApp.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using _01_LibraryApp.Factories;
    using _01_LibraryApp.IO.Contracts;
    using _01_LibraryApp.Models;

    public class Manager
    {
        private const string SUCCESSFULLY_REGISTER_OUTPUT_MESSAGE = "Successfully registered {0} with name: {1}";
        private const string SUCCESSFULLY_CLONE_BOOK_OUTPUT_MESSAGE = "Successfully cloning of the book {0}";
        private const string INVALID_BOOK_NAME_ERROR_MESSAGE = "There is no such book";

        private readonly ICollection<Book> books;
        private readonly IWriter writer;
        private BookFactory bookFactory;

        public Manager(IWriter writer)
        {
            this.books = new List<Book>();
            this.bookFactory = new BookFactory();
            this.writer = writer;
        }

        public string RegisterBook(List<string> arguments)
        {
            string result = string.Empty;

            try
            {
                Book book = bookFactory.Create(arguments);
                this.books.Add(book);
                result = string.Format(SUCCESSFULLY_REGISTER_OUTPUT_MESSAGE, book.GetType().Name, book.Name);
            }
            catch (ArgumentException ae)
            {
                result = ae.Message;
            }

            return result;
        }

        public string CloneBook(string bookName)
        {
            Book book = this.FindBook(bookName);

            bool isExist = book != null;
            if (isExist == false)
            {
                throw new ArgumentException(INVALID_BOOK_NAME_ERROR_MESSAGE);
            }

            Book newBook = book.ShallowCopy();
            this.books.Add(newBook);

            string result = string.Format(SUCCESSFULLY_CLONE_BOOK_OUTPUT_MESSAGE, book.Name);
            return result;
        }

        public void Print()
        {
            foreach (var book in this.books)
            {
                this.writer.WriteLine(book);
            }
        }

        private Book FindBook(string bookName)
        {
            Book book = this.books.FirstOrDefault(b => b.Name == bookName);

            return book;
        }
    }
}
