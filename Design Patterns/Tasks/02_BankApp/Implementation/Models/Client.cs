namespace _02_BankApp.Implementation.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using _02_BankApp.Implementation.Contracts;
    using _02_BankApp.Implementation.Models.Abstraction;
    using _02_BankApp.Infrastructure.Helpers;
    using _02_BankApp.Utilities.Constants.Models;
    using _02_BankApp.Utilities.Messages;

    public class Client : BaseModel, IClient
    {
        private string firstName;
        private string lastName;
        private string identificationNumber;
        private readonly ICollection<Loan> loans;

        public Client(string firstName, string lastName, string IdentificationNumber, BankAccount bankAccount)
            :base()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IdentificationNumber = IdentificationNumber;
            this.BankAccount = bankAccount;
            this.loans = new HashSet<Loan>();
        }

        public string FirstName
        {
            get => this.firstName;
            private set
            {
                this.ValidateName(value, ClientConstants.FIRST_NAME_MIN_LENGHT, nameof(this.FirstName));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                this.ValidateName(value, ClientConstants.LAST_NAME_MIN_LENGHT, nameof(this.LastName));

                this.lastName = value;
            }
        }

        public string IdentificationNumber
        {
            get => this.identificationNumber;
            private set
            {
                bool isValid = CustomValidator.IsIdentificationNumberValid(value);

                if (isValid == false)
                {
                    throw new ArgumentException(ExceptionMessages.INVALID_IDENTIFICATION_NUMBER);
                }

                this.identificationNumber = value;
            }
        }

        public BankAccount BankAccount { get; private set; }

        public IReadOnlyCollection<Loan> Loans => (IReadOnlyCollection<Loan>)this.loans;

        public void AddLoan(Loan loan)
        {
            this.loans.Add(loan);
        }

        private void ValidateName(string value, int valueLenght, string nameOf)
        {
            bool isNull = CustomValidator.IsNullOrWhiteSpace(value);
            bool isInvalid = CustomValidator.IsStringLengthLowerTo(value, valueLenght);

            if (isNull)
            {
                string message = string.Format(ExceptionMessages.NULL_NAME_ERROR_MESSAGE, nameOf);
                throw new ArgumentNullException(message);
            }
            else if (isInvalid)
            {
                string message =
                    string.Format(ExceptionMessages.NAME_MIN_LENGHT_ERROR_MESSAGE, nameOf, valueLenght);
                throw new ArgumentException(message);
            }
        }

        public override string ToString()
        {
            string space = new string(' ', 1);
            string loandsMessage = "Loans: {0}";
            loandsMessage = this.Loans.Count > 0 ? string.Format(loandsMessage, this.Loans.Count) 
                                                 : string.Format(loandsMessage, "none");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First name: {this.FirstName}");
            sb.AppendLine($"Last name: {this.LastName}");
            sb.AppendLine($"IdentificationNumber: {this.IdentificationNumber}");
            sb.AppendLine("BankAccount info:");
            sb.AppendLine($"{this.BankAccount}");
            sb.AppendLine(loandsMessage);

            if (this.Loans.Count > 0)
            {
                int index = 1;
                foreach (var loan in this.Loans)
                {
                    sb.AppendLine($"{space}Loan: #{index++}");
                    sb.AppendLine(loan.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
