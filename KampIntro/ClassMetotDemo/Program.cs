using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ela";
            customer1.Surname = "Yılmaz";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Ali";
            customer2.Surname = "Kara";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Ceylan";
            customer3.Surname = "Akyüz";

            Console.WriteLine("--------------List Customer--------------");

            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Musteri ID : "+customer.Id);
                Console.WriteLine("Musteri Adi-Soyadi : "+ customer.Name+" "+customer.Surname);

            }

            CustomerManager CustomerManager = new CustomerManager();
            CustomerManager.List();

            Console.WriteLine("--------------Add Customer--------------");

            Customer[] customers2 = new Customer[] { customer1, customer2, customer3 };
            foreach (Customer customer in customers2)
            {
                Console.WriteLine("Musteri ID : " + customer.Id);
                Console.WriteLine("Musteri Adi-Soyadi : " + customer.Name + " " + customer.Surname);

            }

            CustomerManager.Add();

            Console.WriteLine("-------------Delete Customer------------");

            Customer[] customers3 = new Customer[] { customer2, customer3};

            foreach (Customer customer in customers3)
            {
                Console.WriteLine("Musteri ID : " + customer.Id);
                Console.WriteLine("Musteri Adi-Soyadi : " + customer.Name + " " + customer.Surname);

            }

            CustomerManager.Delete();




        }
    }
}
