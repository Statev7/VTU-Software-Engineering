namespace P03_Composite.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using P03_Composite.Models;

    public class CompositeFactory 
    {
        private const string INVALID_TYPE_ERROR_MESSAGE = "Invalid composite type!";

        public Composite Create(string[] arguments)
        {
            string typeAsString = arguments[0].ToLower();
            string firstName = arguments[1];
            string lastName = arguments[2];

            Type type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == typeAsString);

            if (type == null)
            {
                throw new ArgumentException(INVALID_TYPE_ERROR_MESSAGE);
            }

            object[] constructorArguments = new object[] { firstName, lastName };
            Composite composite = (Composite)Activator.CreateInstance(type, constructorArguments);

            return composite;
        }
    }
}
