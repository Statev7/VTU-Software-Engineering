namespace _01_LibraryApp.IO.Writer
{
    using System.IO;

    using _01_LibraryApp.IO.Contracts;

    public class FileWriter : IWriter
    {
        private const string PATH = "../../../text.txt";

        public void Write(string text)
        {
            throw new System.NotImplementedException();
        }

        public void WriteLine(object text)
        {
            using (var writer = new StreamWriter(PATH, true))
            {
                writer.WriteLine(text);
            }
        }
    }
}
