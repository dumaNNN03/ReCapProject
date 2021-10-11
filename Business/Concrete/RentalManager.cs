using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [SecuredOperation("user,admin")]
        public IResult Add(Rental rental)
        {
            if (_rentalDal.Get(r=>r.CarId==rental.CarId) == null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.SuccessRent);
            }
            else
            {
                if(_rentalDal.Get(r => r.CarId == rental.CarId).ReturnDate != null)
                {
                    _rentalDal.Add(rental);
                    return new SuccessResult(Messages.SuccessRent);
                }
                return new ErrorResult(Messages.ErrorRent);
            }

            
        }
        [SecuredOperation("admin")]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }
        [SecuredOperation("user,admin")]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Listed);
        }
        [SecuredOperation("user,admin")]
        public IDataResult<Rental> GetById(int Id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == Id), Messages.Listed);
        }
        [SecuredOperation("user,admin")]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
