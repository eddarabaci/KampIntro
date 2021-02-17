using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("--DailyPrice--");
            CarManager carManager = new CarManager(new EfCarDal());
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
