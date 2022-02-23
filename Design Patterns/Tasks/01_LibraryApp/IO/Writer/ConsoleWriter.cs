namespace _01_LibraryApp.IO.Writer
{
    using System;

    using _01_LibraryApp.IO.Contracts;

    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(object text)
        {
            Console.WriteLine(text);
        }
    }
}
