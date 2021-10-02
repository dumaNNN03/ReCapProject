using Entitiy.Concrete;
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
        List<Car> GetCarByBrandId(int Id);
        void Add(Car car);

    }
}
