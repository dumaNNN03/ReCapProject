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

        public List<CarImageDto> GetCarImage(Expression<Func<CarImageDto, bool>> filter)
        {
            using (CarContext context = new())
            {
                var result = from c in context.Car
                             join ci in context.CarImages
                             on c.Id equals ci.CarId
                             select new CarImageDto {  CarId = c.Id, ImagePath = ci.ImagePath };
                return result.Where(filter).ToList();
            }
        }

        public CarImageDto GetDefualtImage(Expression<Func<CarImageDto, bool>> filter)
        {
            using (CarContext context = new())
            {
                var result = from ci in context.CarImages                           
                             select new CarImageDto { CarId = ci.CarId, ImagePath = ci.ImagePath };
                return result.SingleOrDefault(filter);
            }
        }
    }
}
