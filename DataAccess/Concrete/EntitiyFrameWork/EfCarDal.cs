using Core.EntityFramework;
using DataAccess.Abstract;
using Entitiy.Concrete;
using Entitiy.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Car,CarContext>, ICarDal
    {
        public List<CarDetailDto> GetProductDetail()
        {
            using (CarContext context = new())
            {
                var result = from c in context.Car
                             join co in context.Color
                             on c.ColorId equals co.Id
                             join b in context.Brand
                             on c.BrandId equals b.Id
                             select new CarDetailDto { CarName = c.Name,ColorName=co.Name,BrandName=b.Name,DailyPrice =c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
