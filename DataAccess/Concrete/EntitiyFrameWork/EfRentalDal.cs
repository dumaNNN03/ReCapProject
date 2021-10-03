using Core.EntityFramework;
using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>,IRentalDal
    {

    }
}
