namespace P01_Adapter.Adapters
{
    using System.Collections.Generic;

    using P01_Adapter.Adapters.Contracts;
    using P01_Adapter.Models;

    public class EmployeeAdapter : ThirdPartyBillingSystem, ITarget
    {
        public void ProcessCompanySalary(Dictionary<string, decimal> employeeDictionary)
        {
            List<Employee> employees = new List<Employee>();

            foreach (var employee in employeeDictionary)
            {
                Employee employeeToCreate = new Employee(employee.Key.ToString(), employee.Value);
                employees.Add(employeeToCreate);
            }

            this.ProccessSalary(employees);
        }
    }
}
