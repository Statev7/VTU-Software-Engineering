namespace P03_Factory.Models
{
    public abstract class Animal
    {
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}, Name: {this.Name}, Age:{this.Age}";
        }
    }
}
