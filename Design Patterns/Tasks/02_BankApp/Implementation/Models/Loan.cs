namespace _02_BankApp.Implementation.Models
{
    using System;
    using System.Text;

    using _02_BankApp.Implementation.Models.Abstraction;

    public class Loan : BaseModel
    {
        public Loan(DateTime dateOfLoan, decimal amount)
            :base()
        {
            this.DateOfLoan = dateOfLoan;
            this.Amount = amount;
        }

        public DateTime DateOfLoan { get; private set; }

        public decimal Amount { get; private set; }

        public DateTime ExpiryDate => this.DateOfLoan.AddYears(10);

        public override string ToString()
        {
            string space = new string(' ', 3);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{space}Date of loan: {this.DateOfLoan}");
            sb.AppendLine($"{space}Amount: {this.Amount:F2}$");
            sb.AppendLine($"{space}Expiry date: {this.ExpiryDate}");

            return sb.ToString().TrimEnd();
        }
    }
}
