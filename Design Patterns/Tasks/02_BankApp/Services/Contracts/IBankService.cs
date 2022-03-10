namespace _02_BankApp.Services.Contracts
{
    public interface IBankService
    {
        string RegisterClient(params string[] arguments);

        string DepositMoney(string identificationNumber, decimal amount);

        string DrawLoan(string identificationNumber, decimal amount);

        string PrintInformationAboutClient(string identificationNumber);
    }
}
