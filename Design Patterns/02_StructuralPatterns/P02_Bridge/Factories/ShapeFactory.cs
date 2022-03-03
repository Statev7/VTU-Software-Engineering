namespace P02_Bridge.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using P02_Bridge.Abstaction.Models;
    using P02_Bridge.Implementation.Models;

    public class ShapeFactory
    {
        private const string INVALID_SHAPE_ERROR_MESSAGE = "Invalid shape type!";

        private ColorFactory colorFactory;

        public ShapeFactory()
        {
            this.colorFactory = new ColorFactory();
        }

        public Shape Create(List<string> arguments)
        {
            string shapeType = arguments[0];
            string colorType = arguments[1];

            Type type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == shapeType.ToLower());

            if (type == null)
            {
                throw new ArgumentException(INVALID_SHAPE_ERROR_MESSAGE);
            }

            Color color = null;
            try
            {
                color = this.colorFactory.Create(colorType);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            object[] constructor = new object[] { color };
            Shape shape = (Shape)Activator.CreateInstance(type, constructor);

            return shape;
        }
    }
}
