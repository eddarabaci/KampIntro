using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Update(employeeManager);
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
            Console.WriteLine("Musteri eklendi !");
        }

        public void Update()
        {
            Console.WriteLine("Musteri guncellendi!");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel guncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer guncellendi");
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
