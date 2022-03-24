namespace P05_Flyweight.Core
{
    using System;
    using System.Collections.Generic;

    using P05_Flyweight.Core.Contracts;
    using P05_Flyweight.Factories;
    using P05_Flyweight.Models;

    public class Engine : IEngine
    {
        private readonly IDictionary<char, Character> characters;
        private readonly CharacterFactory characterFactory;

        public Engine()
        {
            this.characters = new Dictionary<char, Character>();
            this.characterFactory = new CharacterFactory();
        }

        public void Run()
        {
            string input = "AABBAABBZZZAAC";

            this.CreateCharacters(input);

            string result = string.Empty;
            for (int index = 0; index < input.Length; index++)
            {
                char key = input[index];
                if (this.characters.ContainsKey(key))
                {
                    result += this.characters[key].Name;
                }
            }

            Console.WriteLine(result);
        }

        private void CreateCharacters(string input)
        {
            for (int index = 0; index < input.Length; index++)
            {
                char key = input[index];
                if (!this.characters.ContainsKey(key))
                {
                    Character character = this.characterFactory.Create(key);
                    this.characters.Add(key, character);
                }
            }
        }
    }
}
