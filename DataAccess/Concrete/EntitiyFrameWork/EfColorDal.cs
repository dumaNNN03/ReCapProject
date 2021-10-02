using Core.EntityFramework;
using DataAccess.Abstract;
using Entitiy.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarContext> ,IColorDal
    {
        
    }
}
