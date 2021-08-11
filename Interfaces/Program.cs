using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();

            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Update(new EmployeeManager());
            projectManager.Add(new InternManager());
        }
    }
    interface IPersonManager 
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Codes for adding Customer
            Console.WriteLine("Customer added! ");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated! ");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Codes for adding Employee
            Console.WriteLine("Employee added! ");
        }

        public void Update()
        {
            Console.WriteLine("Employee updated! ");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern added! ");
        }

        public void Update()
        {
            Console.WriteLine("Intern updated! ");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
