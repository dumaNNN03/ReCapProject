using Core.Utilities.Result;
using Entitiy.Concrete;
using Entitiy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetCarByColorId(int Id);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int Id);
        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);

        public IDataResult<List<CarDetailDto>> GetCarDetails();

    }
}
