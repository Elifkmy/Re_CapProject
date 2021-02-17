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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context=new RentACarContext())
            {
                var result = from r in context.Rentals
                             join car in context.Cars
                             on r.CarId equals car.CarId
                             join c in context.Customers
                             on r.CustomerId equals c.CustomerId
                             join u in context.Users
                             on c.UserId equals u.UserId
                             join b in context.Brands
                             on car.BrandId equals b.BrandId
                             join col in context.Colors
                             on car.ColorId equals col.ColorId
                             select new RentalDetailDto {BrandName = b.BrandName, ColorName=col.ColorName, CustomerId = c.CustomerId, FirstName = u.FirstName, LastName = u.LastName, RentDate = r.RentDate, ReturnDate = r.ReturnDate };
                return result.ToList();
            }
        }
    }
}
