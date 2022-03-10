namespace _02_BankApp.IO.Writers
{
    using System;

    using _02_BankApp.IO.Contracts;

    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(object text)
        {
            Console.WriteLine(text.ToString());
        }
    }
}
