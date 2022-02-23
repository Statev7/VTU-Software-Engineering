namespace _01_LibraryApp.IO.Reader
{
    using System;

    using _01_LibraryApp.IO.Contracts;

    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
