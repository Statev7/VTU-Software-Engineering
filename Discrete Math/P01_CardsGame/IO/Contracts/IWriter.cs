namespace CardsGame.IO.Contracts
{
    public interface IWriter
    {
        void WriteLine(string text);

        void Write(string text);
    }
}
