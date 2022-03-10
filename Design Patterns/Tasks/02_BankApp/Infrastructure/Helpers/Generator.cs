namespace _02_BankApp.Infrastructure.Helpers
{
    public static class Generator
    {
        public static long GenerateId()
        {
            IdGenerator generator = IdGenerator.Instance;
            long Id = long.Parse(generator.Id);

            return Id;
        }
    }
}
