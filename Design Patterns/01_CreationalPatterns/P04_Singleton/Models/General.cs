namespace P04_Singleton.Models
{
    using System;
    using System.Collections.Generic;

    public class General
    {
        private ICollection<Soldier> soldiers;
        private static Lazy<General> lazy;

        private General(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.soldiers = new HashSet<Soldier>();
        }

        public static General GetInstance(string name, int age)
        {
            if (lazy == null)
            {
                lazy = new Lazy<General>(() => new General(name, age));
            }

            return lazy.Value;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public IReadOnlyCollection<Soldier> Soldiers => (IReadOnlyCollection<Soldier>)this.soldiers;

        public void Add(Soldier soldier)
        {
            this.soldiers.Add(soldier);
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
