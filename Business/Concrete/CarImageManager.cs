using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entitiy.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        [SecuredOperation("admin")]
        public IResult Add(IFormFile file,CarImage carImage)
        {
            var result = BusinessRules.Run(CheckImageRestriction(carImage.CarId));
            if (result != null)
            {
                return result;
            }

            var result2 = FileHelper.Add(file);
            if (!result2.Success)
            {
                return result2;
            }
            carImage.ImagePath = result2.Message;
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.Added);
        }
        [SecuredOperation("admin")]
        public IResult Delete(CarImage carImage)
        {
            FileHelper.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.Deleted);
        }
        [SecuredOperation("user,admin")]
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(),Messages.Listed);
        }
        [SecuredOperation("user,admin")]
        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c=>c.CarId==carId),Messages.Listed);
        }
        [SecuredOperation("user,admin")]
        public IDataResult<CarImage> GetById(int Id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == Id));
        }
        [SecuredOperation("admin")]
        public IResult Update(IFormFile file,CarImage carImage)
        {
            var result = FileHelper.Update(_carImageDal.Get(c => c.Id == carImage.Id).ImagePath, file);
            if (!result.Success)
            {
                return result;
            }
            carImage.ImagePath = result.Message;
            carImage.Date = DateTime.Now;
            carImage.CarId = _carImageDal.Get(c => c.Id == carImage.Id).CarId;
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Added);
        }

        private IResult CheckImageRestriction(int id)
        {
            var carImageCount = _carImageDal.GetAll(p => p.CarId == id).Count();
            if (carImageCount > 5)
            {
                return new ErrorResult(Messages.ToManyCarImage);
            }

            return new SuccessResult();
        }
    }
}
