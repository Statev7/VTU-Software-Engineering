namespace P02_Bridge.Abstaction.Models
{
    using System;

    using P02_Bridge.Implementation.Models;

    public class Circle : Shape
    {
        public Circle(Color color) 
            : base(color)
        {
        }

        public override void SetColor()
        {
            this.Color.SetColor();
        }
    }
}
