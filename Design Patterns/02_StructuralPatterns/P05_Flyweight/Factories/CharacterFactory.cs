namespace P05_Flyweight.Factories
{
    using P05_Flyweight.Models;

    public class CharacterFactory
    {
        public Character Create(char argument)
        {
            Character character = new Character(argument);
            return character;
        }
    }
}
