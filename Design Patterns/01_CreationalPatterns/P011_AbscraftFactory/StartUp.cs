namespace P011_AbscraftFactory
{
    using System;

    using P011_AbscraftFactory.Factories;
    using P011_AbscraftFactory.Factories.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IFactory modernFactory = new ModernFactory();
            IFactory victorianFactory = new VictorianFactory();

            Client modernClient = new Client(modernFactory);
            Client victorianClient = new Client(victorianFactory);

            Console.WriteLine(modernClient.BuyChair("Something"));
            Console.WriteLine(victorianClient.BuyChair("Something1"));
        }
    }
}
