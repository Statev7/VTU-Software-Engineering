namespace P02_Bridge.Implementation.Models
{
    public abstract class Color
    {
        public abstract string SetColor();

        public override string ToString()
        {
            string color = this.SetColor();
            return color;
        }
    }
}
