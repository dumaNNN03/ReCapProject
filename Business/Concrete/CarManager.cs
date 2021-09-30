﻿using Business.Abstract;
using DataAccess.Abstract;
using Entitiy.Concrete;
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
        public void Add(Car car)
        {
            _carDal.Add(car);
            Console.WriteLine("Ekleme Başarılı");
        }

        public void Delete(int Id)
        {
            _carDal.Delete(Id);
            Console.WriteLine("Silme Başarılı");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int Id)
        {
            return _carDal.GetById(Id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Güncelleme Başarılı");
        }
    }
}
