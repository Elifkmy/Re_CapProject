﻿using Business.Concrete;
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

            //CarUpdate(carManager);
            //CarDetails(carManager);
            ColorTest(colorManager);
            //FilterTest(carManager);
            //CarTable(carManager);
            //ColorTable(colorManager);
            //BrandTable(brandManager);
            //AddTest(carManager);
            //DeleteTest(carManager);
            //Test1(carManager);




        }


        private static void CarUpdate(CarManager carManager)
        {
            var result = carManager.Update(new Car { DailyPrice = 150 });
            Console.WriteLine(result.Message);
        }

        private static void CarDetails(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + "\t" + car.BrandName + "\t  " + car.ColorName + "\t" + car.DailyPrice);
                }
                Console.WriteLine(result.Message);
            }            
        }

        private static void ColorTest(ColorManager colorManager)
        {
            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }      
        }

        private static void FilterTest(CarManager carManager)
        {
            Console.WriteLine("Marka Id'sini giriniz.");
            int a = Convert.ToInt32(Console.ReadLine());
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    a = car.BrandId;
                    if (a == 3)
                    {
                        Console.WriteLine(car.DailyPrice + "\t TL \t" + car.Description);
                    }
                }
            }
           
        }

        private static void CarTable(CarManager carManager)
        {
            Console.WriteLine("   -->>> ARAÇ BİLGİLERİ <<<--");
            Console.WriteLine("|Car Id  | \t |Brand Id  | \t  |Color Id  | \t   |Model Year  | \t |Daily Price  | \t   |Description  |");
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("    " + car.CarId + "\t\t\t " + car.BrandId + "\t\t  " + car.ColorId + "\t\t" + car.ModelYear + "\t\t     " + car.DailyPrice + "\t\t" + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void ColorTable(ColorManager colorManager)
        {
            Console.WriteLine("   -->>> RENK TABLOSU <<<--");
            Console.WriteLine("|Color Id  | \t |Color Name  |");
            var result = colorManager.GetAll();
            if (result.Success==true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine("    " + color.ColorId + "\t\t   " + color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void BrandTable(BrandManager brandManager)
        {
            Console.WriteLine("   -->>> MARKA TABLOSU <<<--");
            Console.WriteLine("|Brand Id  | \t |Brand Name  |");
            var result = brandManager.GetAll();
            if (result.Success==true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine("    " + brand.BrandId + "\t\t   " + brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void AddTest(CarManager carManager)
        {
            carManager.Add(new Car { CarId = 8, BrandId = 12, ColorId = 4, ModelYear = 2019, DailyPrice = 300, Description = "Otomatik Vites/ Benzin" });
        }

        private static void DeleteTest(CarManager carManager)
        {
           carManager.Delete(new Car { CarId = 4 });
        }

        private static void Test1(CarManager carManager)
        {
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Model yılı: " + car.ModelYear + "\tKiralama Fiyatı: " + car.DailyPrice + "\tAçıklama: " + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
