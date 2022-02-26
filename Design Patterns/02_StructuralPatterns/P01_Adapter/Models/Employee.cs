namespace P01_Adapter.Models
{
    public class Employee
    {
        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;   
        }

        public string Name { get; private set; }

        public decimal Salary { get; private set; }

        public override string ToString()
        {
            return $"Name: {this.Name}, Salary: {this.Salary}";
        }
    }
}
