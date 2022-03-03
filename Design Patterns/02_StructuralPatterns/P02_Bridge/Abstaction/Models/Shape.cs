namespace P02_Bridge.Abstaction.Models
{
    using P02_Bridge.Implementation.Models;

    public abstract class Shape
    {
        protected Shape(Color color)
        {
            this.Color = color;
        }

        public Color Color { get; protected set; }

        public abstract void SetColor();

        public override string ToString()
        {
            return $"ShapeType: {this.GetType().Name}, Color: {this.Color}";
        }
    }
}
