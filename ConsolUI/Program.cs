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
            //Carmethod();
            //Colormethod();
            //Brandmethod();
            //Usermethod();
            //Customermethod();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental() {CarId=5, CustomerId=2, RentDate=DateTime.Now, ReturnDate=null };
            var result = rentalManager.Add(rental);
            Console.WriteLine(result.Message);
            
        }

        private static void Customermethod()
        {
            CustomerManager customerManager = new(new EfCustomerDal());
            var result = customerManager.GetAll();
            foreach (var customer in result.Data)
            {
                Console.WriteLine("UserId = {0} CompanyName = {1}", customer.UserId, customer.CompanyName);
            }
            Console.WriteLine(result.Message);
        }

        private static void Usermethod()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetById(1);
            Console.WriteLine(result.Data.FirstName);
            Console.WriteLine(result.Message);
        }

        private static void Brandmethod()
        {
            BrandManager brandManager = new(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.Name);
            }
            Console.WriteLine(result.Message); 
        }

        private static void Colormethod()
        {
            ColorManager colorManager = new(new EfColorDal());
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.Name);
            //}
        }

        private static void Carmethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car() {Id =6,Name = "e5", ColorId = 3, BrandId = 2, DailyPrice = 150, ModelYear = 1990, Description = "Muheteşem" };
            //Car car2 = new Car() { Id = 6, Name = "e6", ColorId = 3, BrandId = 1, DailyPrice = 1000, ModelYear = 1996, Description = "Bi Tık İyi" };
            //foreach (var car in carManager.GetCarByColorId(2))
            //{
            //    Console.WriteLine("{0}", car.Description);
            //}
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("{0}", car.Name);
            //}
            //carManager.Delete(car2);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("{0}", car.Name);
            //}
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine("{0}{1}{2}{3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            //}
            //var result = carManager.Add(car1);
            //Console.WriteLine(result.Message);
            //var result2 = carManager.GetById(6);
            //Console.WriteLine(result2.Data.Name+" \n "+result2.Message );
            var result3 = carManager.Delete(car1);
            Console.WriteLine(result3.Message);
        }
    }
}
