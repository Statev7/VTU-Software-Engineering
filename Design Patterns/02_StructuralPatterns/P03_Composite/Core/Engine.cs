namespace P03_Composite.Core
{
    using System;
    using System.Linq;

    using P03_Composite.Core.Contracts;

    public class Engine : IEngine
    {
        private const string COMMAND_SUFFIX = "_command";

        private const string CREATE_LEAF_COMMAND = "createemployee" + COMMAND_SUFFIX;
        private const string CREATE_COMPOSITE_COMMAND = "createcomposite" + COMMAND_SUFFIX;
        private const string ADD_EMPLOYEE_COMMAND = "addemployee" + COMMAND_SUFFIX;
        private const string DISPLAY_COMMAND = "display" + COMMAND_SUFFIX;
        private const string COMMAND_TO_END_READ = "end" + COMMAND_SUFFIX;

        private Controller controller;

        public Engine()
        {
            this.controller = new Controller();
        }

        public void Run()
        {
            while (true)
            {
                string[] arguments = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = arguments[0].ToLower() + COMMAND_SUFFIX;
                if (command == COMMAND_TO_END_READ)
                {
                    break;
                }

                arguments = arguments.Skip(1).ToArray();
                string result = string.Empty;

                try
                {
                    switch (command)
                    {
                        case CREATE_LEAF_COMMAND:
                            result = this.controller.CreateEmployee(arguments);
                            break;
                        case CREATE_COMPOSITE_COMMAND:
                            result = this.controller.CreateComposite(arguments);
                            break;
                        case ADD_EMPLOYEE_COMMAND:
                            string employeeFirstName = arguments[0];
                            string compositeFirstName = arguments[1];
                            this.controller.AddEmployeeToComposite(employeeFirstName, compositeFirstName);
                            break;
                        case DISPLAY_COMMAND:
                            string compositeFistName = arguments[0];
                            Console.WriteLine(this.controller.Display(compositeFistName));
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                if (result != string.Empty)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
