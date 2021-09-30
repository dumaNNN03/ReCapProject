using Business.Concrete;
using DataAccess.Concrete.InMemoryCarDal;
using Entitiy.Concrete;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Car car1 = new Car() {Id=6,ColorId=5,BrandId=3,DailyPrice=1500,ModelYear=1990,Description="Muheteşem" };
            Car car2 = new Car() { Id = 3, ColorId = 6, BrandId = 4, DailyPrice = 1000,ModelYear = 1996, Description = "Bi Tık İyi" };
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("ID = " +car.Id);
                Console.WriteLine("Brand ID = " + car.BrandId);
                Console.WriteLine("Color ID = " + car.ColorId);
                Console.WriteLine("ModelYear = " + car.ModelYear);
                Console.WriteLine("Daily Price = " + car.DailyPrice);
                Console.WriteLine("Description = " + car.Description);
                Console.WriteLine("--------------------");
            }
            carManager.Add(car1);
            Console.WriteLine("--------------------");
            carManager.Update(car2);
            Console.WriteLine("--------------------");
            carManager.Delete(5);
            Console.WriteLine("--------------------");
            foreach(var car in carManager.GetById(6))
            {
                Console.WriteLine("ID = " + car.Id);
                Console.WriteLine("Brand ID = " + car.BrandId);
                Console.WriteLine("Color ID = " + car.ColorId);
                Console.WriteLine("ModelYear = " + car.ModelYear);
                Console.WriteLine("Daily Price = " + car.DailyPrice);
                Console.WriteLine("Description = " + car.Description);
                Console.WriteLine("--------------------");
            }
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("ID = " + car.Id);
                Console.WriteLine("Brand ID = " + car.BrandId);
                Console.WriteLine("Color ID = " + car.ColorId);
                Console.WriteLine("ModelYear = " + car.ModelYear);
                Console.WriteLine("Daily Price = " + car.DailyPrice);
                Console.WriteLine("Description = " + car.Description);
                Console.WriteLine("--------------------");
            }



        }
    }
}
