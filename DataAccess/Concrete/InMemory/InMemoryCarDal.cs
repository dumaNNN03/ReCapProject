using DataAccess.Abstract;
using Entitiy.Concrete;
using Entitiy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,Name="Doblo",BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=100,Description="Kazalı"},
                new Car{Id=2,Name="Egea",BrandId=1,ColorId=1,ModelYear=2012,DailyPrice=175,Description="Kazasız"},
                new Car{Id=3,Name="Fiesta",BrandId=2,ColorId=2,ModelYear=2015,DailyPrice=250,Description="Kazasız"},
                new Car{Id=4,Name="Focus",BrandId=2,ColorId=2,ModelYear=2019,DailyPrice=300,Description="Kazasız"},
                new Car{Id=5,Name="i8",BrandId=3,ColorId=3,ModelYear=2021,DailyPrice=500,Description="Kazasız"}
            };
        }

        public void Add(Car entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entitiy)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetProductDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
