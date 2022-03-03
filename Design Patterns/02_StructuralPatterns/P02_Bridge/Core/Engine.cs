namespace P02_Bridge.Core
{
    using System;
    using System.Linq;

    using P02_Bridge.Core.Contacts;

    public class Engine : IEngine
    {
        private const string COMMAND_SUFFIX = "_command";

        private const string CREATE_SHAPE_COMMAND = "createshape" + COMMAND_SUFFIX;
        private const string PRINT_COMMAND = "print" + COMMAND_SUFFIX;
        private const string COMMAND_TO_END_READ = "end" + COMMAND_SUFFIX;

        private Manager manager;

        public Engine()
        {
            this.manager = new Manager();
        }

        public void Run()
        {
            string[] arguments = Console.ReadLine().Split().ToArray();

            while (true)
            {
                string command = arguments[0].ToLower() + COMMAND_SUFFIX;
                if (command == COMMAND_TO_END_READ)
                {
                    break;
                }

                switch (command)
                {
                    case CREATE_SHAPE_COMMAND:
                        this.manager.CreateShape(arguments.Skip(1).ToList());
                        break;
                    case PRINT_COMMAND:
                        this.manager.Print();
                        break;
                }

                arguments = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
