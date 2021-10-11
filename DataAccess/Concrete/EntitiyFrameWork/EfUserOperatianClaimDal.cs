using Core.Entities.Concrete;
using Core.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfUserOperatianClaimDal : EfEntityRepositoryBase<UserOperationClaim, CarContext>, IUserOperatianClaimDal
    {
        
    }
}
