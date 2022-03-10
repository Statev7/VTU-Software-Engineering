namespace _02_BankApp.Implementation.Models
{
    using System.Text;

    using _02_BankApp.Enumerators;
    using _02_BankApp.Implementation.Models.Abstraction;
    using _02_BankApp.Utilities.Constants.Models;

    public class BankAccount : BaseModel
    {
        public BankAccount(string fullName)
            :base()
        {
            this.FullName = fullName;
            this.Balance = 0;
            this.Type = AccountType.Regular;
            this.InterestRate = BankAccountConstants.REGULAR_INTEREST_RATE_VALUE;
        }

        public AccountType Type { get; private set; }

        public string FullName { get; private set; }

        public decimal Balance { get; private set; }

        public double InterestRate { get; private set; }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
            this.UpdateData();
        }

        private void UpdateData()
        {
            this.SetType();
            this.SetInterestRate();
        }

        private void SetType()
        {
            if (this.Balance >= BankAccountConstants.MIN_REGULAR_BALANCE_VALUE 
                && this.Balance <= BankAccountConstants.MAX_REGULAR_BALANCE_VALUE)
            {
                this.Type = AccountType.Regular;
            }
            else if (this.Balance >= BankAccountConstants.MIN_BRONZE_BALANCE_VALUE 
                && this.Balance <= BankAccountConstants.MAX_BRONZE_BALANCE_VALUE)
            {
                this.Type = AccountType.Bronze;
            }
            else if(this.Balance >= BankAccountConstants.MIN_GOLD_BALANCE_VALUE 
                && this.Balance <= BankAccountConstants.MAX_GOLD_BALANCE_VALUE)
            {
                this.Type = AccountType.Gold;
            }
            else
            {
                this.Type = AccountType.Platinum;
            }
        }

        private void SetInterestRate()
        {
            switch (this.Type)
            {
                case AccountType.Regular:
                    this.InterestRate = BankAccountConstants.REGULAR_INTEREST_RATE_VALUE;
                    break;
                case AccountType.Bronze:
                    this.InterestRate = BankAccountConstants.BRONZE_INTEREST_RATE_VALUE;
                    break;
                case AccountType.Gold:
                    this.InterestRate = BankAccountConstants.GOLD_INTEREST_RATE_VALUE;
                    break;
                case AccountType.Platinum:
                    this.InterestRate = BankAccountConstants.PLATINUM_INTEREST_RATE_VALUE;
                    break;
            }
        }

        public override string ToString()
        {
            string space = new string(' ', 3);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{space}Full name: {this.FullName}");
            sb.AppendLine($"{space}Type: {this.Type}");
            sb.AppendLine($"{space}Balance: {this.Balance:F2}$");
            sb.AppendLine($"{space}Interest rate: {this.InterestRate}%");

            return sb.ToString().TrimEnd();
        }
    }
}
