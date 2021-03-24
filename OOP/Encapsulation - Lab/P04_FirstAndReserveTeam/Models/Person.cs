namespace PersonsInfo.Models
{

    using System;

    public class Person
    {
        private const int LENGTH_MIN_VALUE = 3;
        private const int AGE_MIN_VALUE = 1;
        private const decimal SALARY_MIN_VALUE = 460m;

        private const string AGE_ZERO_OR_NEGATIVE_VALUE_ERROR_MESSAGE = "Age cannot be zero or a negative integer!";
        private const string FIRST_NAME_LENGHT_ERROR_MESSAGE = "First name cannot contain fewer than 3 symbols!";
        private const string LAST_NAME_LENGHT_ERROR_MESSAGE = "Last name cannot contain fewer than 3 symbols!";
        private const string SALARY_ERROR_MESSAGE = "Salary cannot be less than 460 leva!";

        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                bool isInvalid = value.Length < LENGTH_MIN_VALUE;

                if (isInvalid)
                {
                    throw new ArgumentException(FIRST_NAME_LENGHT_ERROR_MESSAGE);
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                bool isInvalid = value.Length < LENGTH_MIN_VALUE;

                if (isInvalid)
                {
                    throw new ArgumentException(LAST_NAME_LENGHT_ERROR_MESSAGE);
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                bool isInvalid = value < AGE_MIN_VALUE;

                if (isInvalid)
                {
                    throw new ArgumentException(AGE_ZERO_OR_NEGATIVE_VALUE_ERROR_MESSAGE);
                }

                this.age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                bool isInvalid = value < SALARY_MIN_VALUE;

                if (isInvalid)
                {
                    throw new ArgumentException(SALARY_ERROR_MESSAGE);
                }

                this.salary = value;
            }
        }
    }
}
