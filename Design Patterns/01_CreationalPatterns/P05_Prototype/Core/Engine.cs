namespace P05_Prototype.Core
{
    using System;
    using System.Linq;

    using P05_Prototype.Core.Contracts;

    public class Engine : IEngine
    {
        public void Run()
        {
            Manager manager = new Manager();

            while (true)
            {
                string[] arguments = Console.ReadLine().Split(" ").ToArray();

                string command = arguments[0].ToLower();
                if (command == "end")
                {
                    break;
                }

                arguments = arguments.Skip(1).ToArray();
                switch (command)
                {
                    case "create":
                        manager.RegisetVehicle(arguments);
                        break;
                    case "clone":
                        manager.CloneVehicle(arguments[0]);
                        break;
                    case "print":
                        manager.Print();
                        break;
                }
            }
        }
    }
}
