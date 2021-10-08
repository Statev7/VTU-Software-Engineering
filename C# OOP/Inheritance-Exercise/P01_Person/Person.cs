namespace P01_Person
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Person
    {
        private string name;
        private byte age;

        public Person(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public byte Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Name: {this.Name}, Age: {this.Age}");

            return stringBuilder.ToString();
        }
    }
}
