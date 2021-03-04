using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars on rental.CarId equals car.Id
                             join customer in context.Customers on rental.CustomerId equals customer.CustomerId
                             join user in context.Users on customer.UserId equals user.UserId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             select new RentalDetailDto
                             {

                                 RentalId = rental.RentalId,
                                 CarId = car.Id,
                                 CustomerId = customer.CustomerId,
                                 UserId = user.UserId,
                                 CompanyName = customer.CompanyName,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 //RentDate = rental.RentDate,
                                 //ReturnDate = rental.ReturnDate,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Descriptions,

                             };
                return result.ToList();

            }
        }
    }
}
