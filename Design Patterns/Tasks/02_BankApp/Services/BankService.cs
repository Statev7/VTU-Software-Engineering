namespace _02_BankApp.Services
{
    using System;
    using System.Collections.Generic;

    using _02_BankApp.Factories;
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

            bool isClientAlreadyExist = this.bank.FindClientByIdentificationNumber(identificationNumber) != null;
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

            Client client = this.clientFactory.Create(clientArguments);
            this.bank.AddClient(client);

            return OutputMessages.SUCCESSFULY_REGISTERED_CLIENT;
        }

        public string DepositMoney(string identificationNumber, decimal amount)
        {
            Client client = this.bank.FindClientByIdentificationNumber(identificationNumber);
            this.IsClienValid(client);

            if (amount < BankConstants.MINIMUM_AMOUNT_DEPOSIT)
            {
                string message =
                    string.Format(ExceptionMessages.MIN_DEPOSIT_AMOUT_ERROR_MESSAGE, BankConstants.MINIMUM_AMOUNT_DEPOSIT);
                throw new ArgumentException(message);
            }

            client.BankAccount.DepositMoney(amount);
            string result =
                string.Format(OutputMessages.SUCCESSFULY_DEPOSIT, client.BankAccount.FullName, amount, client.BankAccount.Balance);

            return result;
        }

        public string DrawMoney(string identificationNumber, decimal amount)
        {
            Client client = this.bank.FindClientByIdentificationNumber(identificationNumber);
            this.IsClienValid(client);

            if (amount < BankConstants.MINIMUM_AMOUNT_DRAW)
            {
                string message =
                    string.Format(ExceptionMessages.MIN_DRAW_AMOUT_ERROR_MESSAGE, BankConstants.MINIMUM_AMOUNT_DRAW);
                throw new ArgumentException(message);
            }

            client.BankAccount.DrawMoney(amount);
            string result =
                string.Format(OutputMessages.SUCCESSFULY_DRAWN_MONEY, amount, client.BankAccount.Balance);

            return result;
        }

        public string DrawLoan(string identificationNumber, decimal loanAmount)
        {
            Client client = this.bank.FindClientByIdentificationNumber(identificationNumber);
            this.IsClienValid(client);

            if (loanAmount > this.bank.Balance)
            {
                throw new Exception(ExceptionMessages.BANK_DOES_NOT_HAVE_ENOUGH_MONEY);
            }

            if (loanAmount < BankConstants.MINIMUM_LOAN)
            {
                string message = string.Format(ExceptionMessages.MIN_LOAD_ERROR_MESSAGE, BankConstants.MINIMUM_LOAN);
                throw new Exception(message);
            }

            decimal loanResult = this.bank.DrawLoan(client, loanAmount);

            Loan loan = new Loan(DateTime.UtcNow, loanResult);
            client.AddLoan(loan);
            client.BankAccount.DepositMoney(loanAmount);

            return OutputMessages.SUCCESSFULLY_DRAWN_LOAN;
        }

        public string PrintInformationAboutClient(string identificationNumber)
        {
            Client client = this.bank.FindClientByIdentificationNumber(identificationNumber);
            this.IsClienValid(client);

            string result = client.ToString();

            return result;
        }

        private BankAccount CreateBankAccount(string clientFullName)
        {
            return this.bankAccountFactory.Create(clientFullName);
        }

        private void IsClienValid(Client client)
        {
            if (client == null)
            {
                throw new EntityDoesNotExistException(ExceptionMessages.CLIENT_NOT_EXIST_ERROR_MESSAGE);
            }
        }
    }
}
