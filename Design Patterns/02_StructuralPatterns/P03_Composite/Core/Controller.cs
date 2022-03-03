namespace P03_Composite.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using P03_Composite.Factories;
    using P03_Composite.Models;
    using P03_Composite.Models.Contracts;

    public class Controller
    {
        private const string SUCCESSFULY_CREATED_MESSAGE = "Successfully created {0}!";
        private const string INVALID_NAME_ERROR_MESSAGE = "Invalid name!";

        private readonly ICollection<IComponent> employees;
        private EmployeeFactory leafFactory;
        private CompositeFactory compositeFactory;

        public Controller()
        {
            this.employees = new HashSet<IComponent>();
            this.leafFactory = new EmployeeFactory();
            this.compositeFactory = new CompositeFactory();
        }

        public string CreateEmployee(string[] arguments)
        {
            string message = string.Empty;
            try
            {
                IComponent employee = this.leafFactory.Create(arguments);
                this.employees.Add(employee);
                message = string.Format(SUCCESSFULY_CREATED_MESSAGE, employee.GetType().Name);
            }
            catch (ArgumentException ae)
            {
                message = ae.Message;
            }

            return message;
        }

        public string CreateComposite(string[] arguments)
        {
            string message = string.Empty;
            try
            {
                Composite composite = this.compositeFactory.Create(arguments);
                this.employees.Add(composite);
                message = string.Format(SUCCESSFULY_CREATED_MESSAGE, composite.GetType().Name);
            }
            catch (ArgumentException ae)
            {
                message = ae.Message;
            }

            return message;
        }

        public void AddEmployeeToComposite(string employeeName, string compositeName)
        {
            IComponent employee = this.employees.SingleOrDefault(e => e.FirstName == employeeName);
            Composite composite = this.FindComposite(compositeName);

            if (employee == null || composite == null)
            {
                throw new ArgumentException(INVALID_NAME_ERROR_MESSAGE);
            }

            composite.AddEmployee(employee);
        }

        public string Display(string compositeName)
        {
            Composite composite = this.FindComposite(compositeName);

            if (composite == null)
            {
                throw new ArgumentException(INVALID_NAME_ERROR_MESSAGE);
            }

            return composite.DisplayEmployee();
        }

        private Composite FindComposite(string compositeName)
        {
            return (Composite)this.employees.SingleOrDefault(e => e.FirstName == compositeName); 
        }
    }
}
