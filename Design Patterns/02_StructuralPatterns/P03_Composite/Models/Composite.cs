namespace P03_Composite.Models
{
    using System.Collections.Generic;
    using System.Text;

    using P03_Composite.Models.Contracts;

    public class Composite : IComponent
    {
        private readonly ICollection<IComponent> employees;

        private Composite()
        {
            this.employees = new HashSet<IComponent>();
        }

        public Composite(string firstName, string lastName)
            :this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string FullName => $"{this.FirstName} {this.LastName}";

        public void AddEmployee(IComponent employee)
        {
            this.employees.Add(employee);
        }

        public string DisplayEmployee()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}: {this.FullName}");
            foreach (var employee in this.employees)
            {
                sb.AppendLine($"--{employee.DisplayEmployee()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
