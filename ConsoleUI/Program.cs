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
            ColorManager colorManager=new ColorManager(new EfColorDal());

            //carManager.Add(new Car {CarId=7, BrandId = 10, ColorId = 9, ModelYear=2018, DailyPrice = 250, Description="Otomatik Vites/ Benzin" });

            //brandManager.Add(new Brand { BrandId = 12, BrandName = "XY" });
            Console.WriteLine("   -->>> MARKA TABLOSU <<<--");
            Console.WriteLine("|Brand Id  | \t |Brand Name  |");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("    "+ brand.BrandId + "\t\t   " + brand.BrandName);
            }

            Console.WriteLine("   -->>> RENK TABLOSU <<<--");
            Console.WriteLine("|Color Id  | \t |Color Name  |");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("    "+ color.ColorId + "\t\t   " + color.ColorName);
            }
           
            Console.WriteLine("   -->>> ARAÇ BİLGİLERİ <<<--");
            Console.WriteLine("|Car Id  | \t |Brand Id  | \t  |Color Id  | \t   |Model Year  | \t |Daily Price  | \t   |Description  |");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("    " + car.CarId + "\t\t\t " + car.BrandId + "\t\t  " + car.ColorId + "\t\t" + car.ModelYear + "\t\t     " + car.DailyPrice + "\t\t" + car.Description);
            }

            //carManager.Add(new Car
            //{
            //    CarId = 6,
            //    BrandId = 5,
            //    ColorId = 5,
            //    DailyPrice = 80,
            //    ModelYear = 2015,
            //    Description = "Renault/ 2015 - Manuel Vites - Dizel - Mor"
            //});

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Model yılı: " + car.ModelYear + "\tKiralama Fiyatı: " + car.DailyPrice + "\tAçıklama: " + car.Description);
            //}

            //Console.WriteLine("Silmek istediğiniz araç Id numarasını giriniz.");
            //int a;
            //a = Convert.ToInt32(Console.ReadLine());
            //if (a == 4)
            //{
            //    carManager.Delete(new Car { CarId = 4 });
            //    Console.WriteLine("Silme işlemi başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Silme işlemi başarısız");
            //}

            //Car car1 = new Car { CarId = 4 };
            //carManager.Update(car1);


        }
    }
}
