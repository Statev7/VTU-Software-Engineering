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

        public Person(string firstName, string lastName, byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public byte Age { get; private set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"{this.FirstName} {this.LastName} is {this.Age} years old.");
            return str.ToString();
        }
    }
}
