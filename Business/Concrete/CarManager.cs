using Business.Abstract;
using DataAccess.Abstract;
using Entitiy.Concrete;
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
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Günlük Kiralama Bedeli 0 dan büyük olmalıdır.");
            }
        }

        public List<Car> GetCarByBrandId(int Id)
        {
           return _carDal.GetAll(c => c.BrandId == Id);
        }

        public List<Car> GetCarByColorId(int Id)
        {
            return _carDal.GetAll(c => c.ColorId == Id);
        }
    }
}
