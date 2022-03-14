namespace _02_BankApp.Core
{
    using System;
    using System.Linq;

    using _02_BankApp.Core.Contracts;
    using _02_BankApp.Implementation.Models;
    using _02_BankApp.IO.Contracts;
    using _02_BankApp.Services;
    using _02_BankApp.Services.Contracts;

    public class Engine : IEngine
    {
        private const string COMMAND_SUFFIX = "_command";

        private const string COMMAND_TO_END_READ = "end" + COMMAND_SUFFIX;
        private const string REGISTER_CLIENT = "registerclient" + COMMAND_SUFFIX;
        private const string DRAW_LOAN = "drawloan" + COMMAND_SUFFIX;
        private const string DEPOSIT_MONEY = "deposit" + COMMAND_SUFFIX;
        private const string DRAW_MONEY = "draw" + COMMAND_SUFFIX;
        private const string CLIENT_INFORMATION = "information" + COMMAND_SUFFIX;

        private readonly Bank bank;
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.bank = new Bank("DSK", 500000);
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            IBankService bankService = new BankService(bank);

            while (true)
            {
                string[] arguments = this.reader.Read()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = arguments[0].ToLower() + COMMAND_SUFFIX;
                arguments = arguments.Skip(1).ToArray();

                if (command == COMMAND_TO_END_READ)
                {
                    Environment.Exit(0);
                }

                string message = string.Empty;
                try
                {
                    switch (command)
                    {
                        case REGISTER_CLIENT:
                            message = bankService.RegisterClient(arguments.ToArray());
                            break;
                        case DRAW_LOAN:
                            message = bankService.DrawLoan(arguments[0], decimal.Parse(arguments[1]));
                            break;
                        case DEPOSIT_MONEY:
                            message = bankService.DepositMoney(arguments[0], decimal.Parse(arguments[1]));
                            break;
                        case DRAW_MONEY:
                            message = bankService.DrawMoney(arguments[0], decimal.Parse(arguments[1]));
                            break;
                        case CLIENT_INFORMATION:
                            message = bankService.PrintInformationAboutClient(arguments[0]);
                            break;
                    }
                }
                catch (Exception e)
                {
                    this.writer.WriteLine(e.Message);
                }

                if (message.Length != 0) this.writer.WriteLine(message);
            }
        }
    }
}
