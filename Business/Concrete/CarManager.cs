using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Aspects.Caching;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entitiy.Concrete;
using Entitiy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        
        [ValidationAspect(typeof(CarValidator))]
        [SecuredOperation("admin")]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.Added);
        }
        [SecuredOperation("admin")]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }
        [SecuredOperation("user,admin")]
        [CacheAspect]
        public IDataResult<Car> GetById(int Id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.Id==Id),Messages.Listed);
        }
        [SecuredOperation("user,admin")]
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }

        [SecuredOperation("user,admin")]
        [CacheAspect]
        public IDataResult<List<Car>> GetCarByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == Id), Messages.Listed);
        }
        [SecuredOperation("admin")]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }
        [SecuredOperation("user,admin")]
        [CacheAspect]
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetProductDetail(), Messages.Listed);
        }
        [SecuredOperation("user,admin")]
        [CacheAspect]
        public IDataResult<List<CarImageDto>> GetCarImageById(int Id)
        {
            var result = _carDal.GetCarImage(c=>c.CarId==Id);
            if (result.Count > 0)
            {
                return new SuccessDataResult<List<CarImageDto>>(result,Messages.Listed);
            }
            result.Add(_carDal.GetDefualtImage(c => c.CarId == 0));
            return new SuccessDataResult<List<CarImageDto>>(result,Messages.Listed);
        }

       
    }
}
