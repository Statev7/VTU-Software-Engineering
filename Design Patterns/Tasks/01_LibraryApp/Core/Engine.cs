namespace _01_LibraryApp.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using _01_LibraryApp.Core.Contracts;
    using _01_LibraryApp.IO.Contracts;

    public class Engine : IEngine
    {
        private const string COMMAND_SUFFIX = "_command";

        private const string CREATE_COMMAND = "create" + COMMAND_SUFFIX;
        private const string CLONE_COMMAND = "clone" + COMMAND_SUFFIX;
        private const string COMMAND_TO_END_READ = "end" + COMMAND_SUFFIX;

        private readonly IReader reader;
        private readonly IWriter writer;
        private Manager manager;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            this.manager = new Manager(writer);
        }

        public void Run()
        {
            while (true)
            {
                List<string> arguments = this.reader.Read()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                string command = arguments[0].ToLower() + COMMAND_SUFFIX;

                if (command == COMMAND_TO_END_READ)
                {
                    break;
                }

                arguments.RemoveAt(0);
                string result = string.Empty;

                if (command == CREATE_COMMAND)
                {
                    result = RegisterBook(arguments);
                }
                else if (command == CLONE_COMMAND)
                {
                    string bookName = arguments[0];
                    result = CloneBook(bookName);
                }

                this.writer.WriteLine(result);
            }

            this.manager.Print();
        }

        private string RegisterBook(List<string> arguments)
        {
            return this.manager.RegisterBook(arguments);
        }

        private string CloneBook(string bookName)
        {
            string result;
            try
            {
                result = this.manager.CloneBook(bookName);
            }
            catch (ArgumentException ae)
            {
                result = ae.Message;
            }

            return result;
        }
    }
}
