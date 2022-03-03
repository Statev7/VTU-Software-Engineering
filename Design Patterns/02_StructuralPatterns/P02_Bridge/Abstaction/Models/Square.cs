using P02_Bridge.Implementation.Models;

namespace P02_Bridge.Abstaction.Models
{
    public class Square : Shape
    {
        public Square(Color color) 
            : base(color)
        {
        }

        public override void SetColor()
        {
            this.Color.SetColor();
        }
    }
}
