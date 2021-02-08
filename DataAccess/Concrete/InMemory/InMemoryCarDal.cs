using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{CarId=1, BrandId=2, ColorId=1, DailyPrice=290, ModelYear=2020, Description="Peugeot 3008/ 2020 - Manuel Vites - Benzin - Beyaz"},
            new Car{CarId=2, BrandId=3, ColorId=1, DailyPrice=335, ModelYear=2018, Description="Mercedes-Benz/ 2018 - Otomatik Vites - Dizel - Beyaz"},
            new Car{CarId=3, BrandId=1, ColorId=4, DailyPrice=559, ModelYear=2018, Description="BMW 3008/ 2018 - Otomatik Vites - Dizel - Siyah"},
            new Car{CarId=4, BrandId=2, ColorId=3, DailyPrice=150, ModelYear=2017, Description="Peugeot/ 2017 -Otomatik Vites - Benzin - Gri"},
            new Car{CarId=5, BrandId=4, ColorId=2, DailyPrice=120, ModelYear=2018, Description="Fiat/ 2018 - Manuel Vites - Dizel - Kırmızı"}
            };
        }
        public void Add(Car carId)
        {
            _cars.Add(carId);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = carToUpdate.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
