using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFrameWork;
using DataAccess.Concrete.InMemoryCarDal;
using Entitiy.Concrete;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car() {Id=6,ColorId=5,BrandId=2,DailyPrice=150,ModelYear=1990,Description="Muheteşem" };
            Car car2 = new Car() {Id = 3, ColorId = 6, BrandId = 4, DailyPrice = 1000,ModelYear = 1996, Description = "Bi Tık İyi" };
            carManager.Add(car1);
            foreach (var car in carManager.GetCarByBrandId(2))
            {
                Console.WriteLine("{0}",car.Description);
            }
            



        }
    }
}
