using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal() 
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId=1, ColorId = 1, DailyPrice = 150, ModelYear="2017", Descriptions = "Opel Astra" },
                new Car{Id = 2, BrandId=2, ColorId = 3, DailyPrice = 300, ModelYear="2012", Descriptions = "Mercedes AMG" },
                new Car{Id = 3, BrandId=3, ColorId = 2, DailyPrice = 170, ModelYear="2018", Descriptions = "Peugeot 208 1.2" },
                new Car{Id = 4, BrandId=3, ColorId = 1, DailyPrice = 250, ModelYear="2020", Descriptions = "Peugeot 2008 SUV" },
                new Car{Id = 5, BrandId=4, ColorId = 2, DailyPrice = 190, ModelYear="2016", Descriptions = "Toyota Yaris Hibrid" },

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(pcar => pcar.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(pcar => pcar.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(pcar => pcar.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
            carToUpdate.ModelYear = car.ModelYear;
           
        }
    }
}
