using Core.EntityFramework;
using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage,CarContext> , ICarImageDal
    {
      
    }
}
