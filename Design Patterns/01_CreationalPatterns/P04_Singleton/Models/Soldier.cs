namespace P04_Singleton.Models
{
    public class Soldier
    {
        public Soldier(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
