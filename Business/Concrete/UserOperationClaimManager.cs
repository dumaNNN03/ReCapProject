using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserOperationClaimManager : IUserOperatianClaimService
    {
        IUserOperatianClaimDal _userOperatianClaimDal;
        public UserOperationClaimManager(IUserOperatianClaimDal userOperatianClaimDal)
        {
            _userOperatianClaimDal = userOperatianClaimDal;
        }
        public void AddUserClaim(User user)
        {
            var userclaim = new UserOperationClaim()
            {
                UserId = user.Id,
                OperationClaimId = 2
            
            };
            _userOperatianClaimDal.Add(userclaim);
        }
    }
}
