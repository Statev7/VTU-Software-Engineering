namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Person
    {
        private string firstName;
        private string lastName;
        private byte age;
        private decimal salary;

        public Person(string firstName, string lastName, byte age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public byte Age { get; private set; }
        public decimal Salary { get;  set; }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.");
            return str.ToString(); 
        }
    }
}
