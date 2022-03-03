namespace P03_Composite.Models
{
    using P03_Composite.Models.Contracts;

    public abstract class Employee : IComponent
    {
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{this.FirstName} {this.LastName}";

        public string DisplayEmployee()
        {
            return $"--{this.GetType().Name}: {this.FullName}";
        }
    }
}
