namespace _02_BankApp.IO.Contracts
{
    public interface IWriter
    {
        void WriteLine(object text);

        void Write(string text);
    }
}
