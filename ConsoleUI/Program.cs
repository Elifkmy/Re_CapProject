using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            NewMethod(carManager);


            //FilterTest(carManager);
            //AddTest(carManager);
            //BrandAddTest(brandManager);
            //BrandTable(brandManager);
            //ColorTable(colorManager);
            //CarTable(carManager);
            //CarTest(carManager);
            //Test1(carManager);
            //DeleteTest(carManager);
            //Car car1 = new Car { CarId = 4 };
            //carManager.Update(car1);


        }

        private static void NewMethod(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + "\t" + car.BrandName + "\t  " + car.ColorName + "\t" + car.DailyPrice);
            }
        }

        private static void FilterTest(CarManager carManager)
        {
            Console.WriteLine("Marka Id'sini giriniz.");
            int a = Convert.ToInt32(Console.ReadLine());
            foreach (var car in carManager.GetAll())
            {
                a = car.BrandId;
                if (a == 3)
                {
                    Console.WriteLine(car.DailyPrice + "\t TL \t" + car.Description);
                }
            }
        }

        private static void CarTable(CarManager carManager)
        {
            Console.WriteLine("   -->>> ARAÇ BİLGİLERİ <<<--");
            Console.WriteLine("|Car Id  | \t |Brand Id  | \t  |Color Id  | \t   |Model Year  | \t |Daily Price  | \t   |Description  |");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("    " + car.CarId + "\t\t\t " + car.BrandId + "\t\t  " + car.ColorId + "\t\t" + car.ModelYear + "\t\t     " + car.DailyPrice + "\t\t" + car.Description);
            }
        }

        private static void ColorTable(ColorManager colorManager)
        {
            Console.WriteLine("   -->>> RENK TABLOSU <<<--");
            Console.WriteLine("|Color Id  | \t |Color Name  |");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("    " + color.ColorId + "\t\t   " + color.ColorName);
            }
        }

        private static void BrandTable(BrandManager brandManager)
        {
            Console.WriteLine("   -->>> MARKA TABLOSU <<<--");
            Console.WriteLine("|Brand Id  | \t |Brand Name  |");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("    " + brand.BrandId + "\t\t   " + brand.BrandName);
            }
        }

        private static void BrandAddTest(BrandManager brandManager)
        {
            brandManager.Add(new Brand { BrandId = 12, BrandName = "XY" });
        }

        private static void AddTest(CarManager carManager)
        {
            carManager.Add(new Car { CarId = 7, BrandId = 10, ColorId = 9, ModelYear = 2018, DailyPrice = 250, Description = "Otomatik Vites/ Benzin" });
        }

        private static void DeleteTest(CarManager carManager)
        {
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
        }

        private static void Test1(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Model yılı: " + car.ModelYear + "\tKiralama Fiyatı: " + car.DailyPrice + "\tAçıklama: " + car.Description);
            }
        }

        private static void CarTest(CarManager carManager)
        {
            carManager.Add(new Car
            {
                CarId = 6,
                BrandId = 5,
                ColorId = 5,
                DailyPrice = 80,
                ModelYear = 2015,
                Description = "Renault/ 2015 - Manuel Vites - Dizel - Mor"
            });
        }
    }
}
