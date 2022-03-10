namespace _02_BankApp.Implementation.Models.Abstraction
{
    using _02_BankApp.Infrastructure.Helpers;

    public abstract class BaseModel
    {
        public BaseModel()
        {
            this.Id = Generator.GenerateId();
        }

        public long Id { get; private set; }
    }
}
