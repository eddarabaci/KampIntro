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
            //CarAdd();
            //CarGetDetails();
            CarGetAll();

            //CustomerAdd();
            RentalCarAdd();
            GetRentalDetails();



        }

        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer
            {
                CompanyName = "Car Renting" ,
                UserId = 3
            });
            System.Console.WriteLine(result.Message);
        }
        private static void RentalCarAdd()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            {
                CarId = 5,
                CustomerId = 1002,
                RentDate = DateTime.Now,
                ReturnDate = new DateTime(2021, 01, 30)
            });
            System.Console.WriteLine(result.Message);
        }
        private static void GetRentalDetails()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetails();

            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    System.Console.WriteLine("{0} / {1} / {2} / {3}", rental.BrandName, rental.ColorName, rental.ModelYear, rental.FirstName);
                }
            }
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

            var result = carManager.Add(new Car { BrandId = 2, ColorId = 3, DailyPrice = 1000, ModelYear = "2021", Descriptions = "Mercedes Benz Full" });

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
