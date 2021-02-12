using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car carId)
        {
            if (carId.DailyPrice>0)
            {
                _carDal.Add(carId);
            }
            else
            {
                Console.WriteLine("Günlük araç kiralama fiyatı 0 olamaz.");
            }
            
        }

        public void Delete(Car carId)
        {
            _carDal.Delete(carId);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.Get(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public Car GetCarsByBrandId(int id)
        {
            return _carDal.Get(c => c.BrandId == id);
        }

        public Car GetCarsByColorId(int id)
        {
            return _carDal.Get(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
