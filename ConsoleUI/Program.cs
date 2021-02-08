using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }


            carManager.Add(new Car
            {
                CarId = 6,
                BrandId = 5,
                ColorId = 5,
                DailyPrice = 80,
                ModelYear = 2015,
                Description = "Renault/ 2015 - Manuel Vites - Dizel - Mor"
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Model yılı: " + car.ModelYear + "\tKiralama Fiyatı: " + car.DailyPrice + "\tAçıklama: " + car.Description);
            }

            Console.WriteLine("Silmek istediğiniz araç Id numarasını giriniz.");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 4)
            {
                carManager.Delete(new Car { CarId = 4 });
                Console.WriteLine("Silme işlemi başarılı");
            }
            else
            {
                Console.WriteLine("Silme işlemi başarısız");
            }

            Car car1 = new Car { CarId = 4 };
            carManager.Update(car1);

            carManager.GetById(4);
        }
    }
}
