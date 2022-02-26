namespace P01_Adapter.Core
{
    using System.Collections.Generic;

    using P01_Adapter.Adapters;
    using P01_Adapter.Adapters.Contracts;
    using P01_Adapter.Core.Contracts;

    public class Engine : IEngine
    {
        public void Run()
        {
            Dictionary<string,decimal> employees = new Dictionary<string, decimal>();

            for (int i = 1; i <= 5; i++)
            {
                decimal salary = i * 350;
                employees[i.ToString()] = salary;
            }

            ITarget adapter = new EmployeeAdapter();
            adapter.ProcessCompanySalary(employees);
        }
    }
}
