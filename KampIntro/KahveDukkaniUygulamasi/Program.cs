using KahveDukkaniUygulamasi.Abstract;
using KahveDukkaniUygulamasi.Adapters;
using KahveDukkaniUygulamasi.Concrete;
using KahveDukkaniUygulamasi.Entity;
using System;

namespace KahveDukkaniUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1992, 10, 2), FirstName = "Eda", LastName = "Arabacı",NationalityId = "47845944274" });
            Console.ReadLine();
        }
    }
}
