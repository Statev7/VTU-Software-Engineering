namespace PlayersAndMonsters
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Hero
    {
        private string userName;
        private int level;

        public Hero(string userName, int level)
        {
            this.UserName = userName;
            this.Level = level;
        }

        public string UserName { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Type: {this.GetType().Name} Username: {this.UserName} Level: {this.Level}");
            return stringBuilder.ToString(); 
        }
    }
}
