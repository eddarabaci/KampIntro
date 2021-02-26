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
            //GetByBrandId();

            //GetByColorId();

            CarAdd();

            CarGetDetails();

            CarGetAll();

        }

        private static void CarGetDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine(car.Id + " / " + car.ColorName + " / " + car.BrandName + " / " + car.ModelYear);
                }
            }
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine(car.Descriptions);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }

        private static void GetByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAllByColorId(3);

            foreach (var car in result.Data)
            {
                System.Console.WriteLine(car.Descriptions);

            }
        }

        private static CarManager GetByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAllByBrandId(1);
            foreach (var car in result.Data )
            {
                System.Console.WriteLine(car.Descriptions);

            }
            return carManager;
        }

        private static CarManager CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Delete(new Car { Id = 1004, BrandId = 2, ColorId = 3, DailyPrice = 300, ModelYear = "1990", Descriptions = "Old Mercedes" });

            var result = carManager.GetByDailyPrice(100, 200);

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine(car.Descriptions);

                }
            }
            return carManager;
        }

        private static CarManager CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.Add(new Car { BrandId = 2, ColorId = 3, DailyPrice = 0, ModelYear = "2021", Descriptions = "Mercedes Benz Full" });

            System.Console.WriteLine(result.Message);

            return carManager;

            //var result = carManager.GetAll();

            //foreach (var car in result.Data)
            //{
            //    System.Console.WriteLine(car.Descriptions);
            //}

        }
    }
}
