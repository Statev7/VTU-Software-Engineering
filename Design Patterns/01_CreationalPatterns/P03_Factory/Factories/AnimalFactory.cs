namespace P03_Factory.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using P03_Factory.Models;

    public class AnimalFactory
    {
        public Animal Create(List<string> arg)
        {
            Type type = Assembly.GetCallingAssembly()
               .GetTypes()
               .FirstOrDefault(t => t.Name.ToLower() == arg[0]);

            string name = arg[1];
            int age = int.Parse(arg[2]);

            object[] constructorArguments = new object[] { name, age };

            Animal animal = (Animal)Activator.CreateInstance(type, constructorArguments);

            return animal;
        }
    }
}
