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
        List<Car> GetCarByColorId(int Id);
        List<Car> GetAll();
        Car GetById(int Id);
        void Add(Car car);

        void Delete(Car car);

        void Update(Car car);

        public List<CarDetailDto> GetCarDetails();

    }
}
