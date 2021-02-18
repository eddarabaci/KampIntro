using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("--DailyPrice--");
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car {BrandId =4, ColorId = 2, DailyPrice = 300, ModelYear ="2012", Descriptions="Toyota Auris"});

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Descriptions);
            }

            carManager.Delete(new Car { Id = 1004 ,BrandId = 2, ColorId = 3, DailyPrice = 300, ModelYear = "1990", Descriptions = "Old Mercedes" });


            foreach (var car in carManager.GetByDailyPrice(100,200))
            {
                System.Console.WriteLine(car.Descriptions);

            }

            System.Console.WriteLine("--BrandId--");

            foreach (var car in carManager.GetAllByBrandId(3))
            {
                System.Console.WriteLine(car.Descriptions);

            }
            System.Console.WriteLine("--ColorId--");

            foreach (var car in carManager.GetAllByColorId(2))
            {
                System.Console.WriteLine(car.Descriptions);

            }

        }
    }
}
