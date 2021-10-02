using Business.Abstract;
using DataAccess.Abstract;
using Entitiy.Concrete;
using Entitiy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.DailyPrice > 0)
            {
                if (car.Name.Length < 2)
                {
                    Console.WriteLine("Araba ismi minimum 2 karakter olmak zorundadır.");
                }
                else
                {
                    _carDal.Add(car); 
                }
            }
            else
            {
                Console.WriteLine("Günlük Kiralama Bedeli 0 dan büyük olmalıdır.");
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car GetById(int Id)
        {
            return _carDal.Get(c=>c.Id==Id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }


        public List<Car> GetCarByColorId(int Id)
        {
            return _carDal.GetAll(c => c.ColorId == Id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetProductDetail();
        }
    }
}
