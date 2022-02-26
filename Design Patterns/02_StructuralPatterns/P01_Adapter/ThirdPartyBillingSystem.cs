namespace P01_Adapter
{
    using System;
    using System.Collections.Generic;

    using P01_Adapter.Models;

    public class ThirdPartyBillingSystem
    {
        public void ProccessSalary(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
