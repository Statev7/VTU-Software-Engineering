namespace P05_Flyweight.Models
{
    public class Character
    {
        public Character(char name)
        {
            this.Name = name;
            this.Hight = 100;
        }

        public char Name { get; private set; }

        public int Hight { get; private set; }
    }
}
