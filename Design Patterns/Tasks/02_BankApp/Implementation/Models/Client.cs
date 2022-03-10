namespace _02_BankApp.Implementation.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using _02_BankApp.Implementation.Contracts;
    using _02_BankApp.Implementation.Models.Abstraction;
    using _02_BankApp.Infrastructure.Helpers;
    using _02_BankApp.Utilities.Constants.Models;

    public class Client : BaseModel, IClient
    {
        private readonly ICollection<Loan> loans;
        private string firstName;

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
                string message = string.Empty;

                bool isNull = CustomValidator.IsNullOrWhiteSpace(value);
                bool isInvalid = CustomValidator.IsStringLengthLowerTo(value, ClientConstants.FIRST_NAME_MIN_LENGHT);

                if (isNull)
                {
                    //TODO throw exception!
                }
                else if (isInvalid)
                {

                }

                if(message.Length != 0)
                {

                }

                this.firstName = value;
            }
        }

        public string LastName { get; private set; }

        public string IdentificationNumber { get; private set; }

        public BankAccount BankAccount { get; private set; }

        public IReadOnlyCollection<Loan> Loans => (IReadOnlyCollection<Loan>)this.loans;

        public void AddLoan(Loan loan)
        {
            this.loans.Add(loan);
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
