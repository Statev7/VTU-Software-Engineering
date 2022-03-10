namespace _02_BankApp.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using _02_BankApp.Factories;
    using _02_BankApp.Implementation.Contracts;
    using _02_BankApp.Implementation.Models;
    using _02_BankApp.Services.Contracts;
    using _02_BankApp.Utilities.Constants.Models;
    using _02_BankApp.Utilities.Exceptions;
    using _02_BankApp.Utilities.Messages;

    public class BankService : IBankService
    {
        private readonly Bank bank;
        private readonly BankAccountFactory bankAccountFactory;
        private readonly ClientFactory clientFactory;

        public BankService(Bank bank)
        {
            this.bank = bank;
            this.bankAccountFactory = new BankAccountFactory();
            this.clientFactory = new ClientFactory();
        }

        public string RegisterClient(params string[] arguments)
        {
            string firstName = arguments[0];
            string lastName = arguments[1];
            string identificationNumber = arguments[2];

            bool isClientAlreadyExist = this.FindClientByIdentificationNumber(identificationNumber) != null;
            if (isClientAlreadyExist)
            {
                string errorMessage = 
                    string.Format(ExceptionMessages.CLIENT_ALREADY_REGISTERED_ERROR_MESSAGE, firstName, lastName);

                throw new ClientAlreadyRegistreted(errorMessage);
            }

            string fullName = $"{firstName} {lastName}";
            BankAccount bankAccount = this.CreateBankAccount(fullName);

            List<object> clientArguments = 
                new List<object>() { firstName, lastName, identificationNumber, bankAccount };

            IClient client = this.clientFactory.Create(clientArguments);
            this.bank.AddClient(client);

            return OutputMessages.SUCCESSFULY_REGISTERED_CLIENT;
        }

        public string DepositMoney(string identificationNumber, decimal amount)
        {
            IClient client = this.FindClientByIdentificationNumber(identificationNumber);
            this.IsClienValid(client);

            if (amount < BankConstants.MINUMUM_AMOUNT_DEPOSIT)
            {
                string message =
                    string.Format(ExceptionMessages.MIN_DEPOSIT_AMOUT_ERROR_MESSAGE, BankConstants.MINUMUM_AMOUNT_DEPOSIT);
                throw new ArgumentException(message);
            }

            client.BankAccount.DepositMoney(amount);
            string result =
                string.Format(OutputMessages.SUCCESSFULY_DEPOSIT, client.BankAccount.FullName, amount, client.BankAccount.Balance);

            return result;
        }

        public string DrawLoan(string identificationNumber, decimal loanAmount)
        {
            IClient client = this.FindClientByIdentificationNumber(identificationNumber);
            this.IsClienValid(client);

            if (loanAmount > this.bank.Balance)
            {
                throw new Exception(ExceptionMessages.BANK_DOES_NOT_HAVE_ENOUGH_MONEY);
            }

            if (loanAmount < BankConstants.MINUMUM_LOAN)
            {
                string message = string.Format(ExceptionMessages.MIN_LOAD_ERROR_MESSAGE, BankConstants.MINUMUM_LOAN);
                throw new Exception(message);
            }

            decimal loanResult = CalculateLoan(client, loanAmount);
            this.bank.DrawLoan(loanResult);

            Loan loan = new Loan(DateTime.UtcNow, loanResult);
            client.AddLoan(loan);
            client.BankAccount.DepositMoney(loanAmount);

            return OutputMessages.SUCCESSFULLY_DRAWN_LOAN;
        }

        public string PrintInformationAboutClient(string identificationNumber)
        {
            IClient client = this.FindClientByIdentificationNumber(identificationNumber);
            this.IsClienValid(client);

            string result = client.ToString();

            return result;
        }

        private decimal CalculateLoan(IClient client, decimal loanAmount)
        {
            double rate = 0;

            switch (client.BankAccount.Type)
            {
                case Enumerators.AccountType.Regular:
                    rate = LoanConstants.REGULAR_RATE_VALUE;
                    break;
                case Enumerators.AccountType.Bronze:
                    rate = LoanConstants.BRONZE_RATE_VALUE;
                    break;
                case Enumerators.AccountType.Gold:
                    rate = LoanConstants.GOLD_RATE_VALUE;
                    break;
                case Enumerators.AccountType.Platinum:
                    rate = LoanConstants.PLATINUM_RATE_VALUE;
                    break;
            }

            decimal loan = (loanAmount * (decimal)rate) + loanAmount;
            return loan;
        }

        private BankAccount CreateBankAccount(string clientFullName)
        {
            return this.bankAccountFactory.Create(clientFullName);
        }

        private IClient FindClientByIdentificationNumber(string identificationNumber)
        {
            IClient client = this.bank.Clients.SingleOrDefault(c => c.IdentificationNumber == identificationNumber);

            return client;
        }

        private void IsClienValid(IClient client)
        {
            if (client == null)
            {
                throw new EntityDoesNotExistException(ExceptionMessages.CLIENT_NOT_EXIST_ERROR_MESSAGE);
            }
        }
    }
}
