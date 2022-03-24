namespace P06_Facada.Factories.Contracts
{
    public interface IFactory<TEntity>
    {
        TEntity Create(object argument);
    }
}
