using System.Collections.Generic;

namespace P01_Adapter.Adapters.Contracts
{
    public interface ITarget
    {
        void ProcessCompanySalary(Dictionary<string, decimal> employeeDictionary);
    }
}
