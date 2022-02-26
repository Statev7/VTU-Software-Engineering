namespace P03_Factory.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using P03_Factory.Core.Contracts;
    using P03_Factory.Factories;
    using P03_Factory.Models;

    public class Engine : IEngine
    {
        private const string COMMAND_SUFFIX = "_command";

        private const string CREATE_COMMAND = "create" + COMMAND_SUFFIX;
        private const string COMMAND_TO_END_READ_INPUT = "end" + COMMAND_SUFFIX;

        private AnimalFactory animalFactory;

        public Engine()
        {
            this.animalFactory = new AnimalFactory();
        }

        public void Run()
        {
            List<Animal> animals = new List<Animal>();
            Animal animal = null;

            while (true)
            {
                List<string> arguments = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string command = arguments[0].ToLower() + COMMAND_SUFFIX;
                if (command == COMMAND_TO_END_READ_INPUT)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, animals));
                    break;
                }

                arguments = arguments.Skip(1).ToList();
                switch (command)
                {
                    case CREATE_COMMAND:
                        animal = this.animalFactory.Create(arguments);
                        break;
                }

                animals.Add(animal);
            }
        }
    }
}
