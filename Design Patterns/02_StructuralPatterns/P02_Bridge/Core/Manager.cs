namespace P02_Bridge.Core
{
    using System;
    using System.Collections.Generic;

    using P02_Bridge.Abstaction.Models;
    using P02_Bridge.Factories;

    public class Manager
    {
        private readonly List<Shape> shapes;
        private ShapeFactory shapeFactory;

        public Manager()
        {
            this.shapes = new List<Shape>();
            this.shapeFactory = new ShapeFactory();
        }

        public void CreateShape(List<string> arguments)
        {
            Shape shape = null;

            try
            {
                shape = this.shapeFactory.Create(arguments);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            this.shapes.Add(shape);
        }

        public void Print()
        {
            Console.WriteLine(string.Join(Environment.NewLine, shapes));
        }
    }
}
