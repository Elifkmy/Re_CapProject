using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

        Car GetByDailyPrice(decimal min, decimal max);
        Car GetCarsByBrandId(int id);
        Car GetCarsByColorId(int id);
        List<CarDetailDto> GetCarDetails();
    }
}
