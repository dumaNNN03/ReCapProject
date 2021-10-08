using Core.DataAccess;
using Entitiy.Concrete;
using Entitiy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        public List<CarDetailDto> GetProductDetail();
        public List<CarImageDto> GetCarImage(Expression<Func<CarImageDto, bool>> filter);
        public CarImageDto GetDefualtImage(Expression<Func<CarImageDto, bool>> filter);
    }
}
