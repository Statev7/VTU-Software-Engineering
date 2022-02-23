namespace _01_LibraryApp.IO.Contracts
{
    public interface IWriter
    {
        void WriteLine(object text);

        void Write(string text);
    }
}
