﻿using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=100,Description="Kazalı"},
                new Car{Id=2,BrandId=1,ColorId=1,ModelYear=2012,DailyPrice=175,Description="Kazasız"},
                new Car{Id=3,BrandId=2,ColorId=2,ModelYear=2015,DailyPrice=250,Description="Kazasız"},
                new Car{Id=4,BrandId=2,ColorId=2,ModelYear=2019,DailyPrice=300,Description="Kazasız"},
                new Car{Id=5,BrandId=3,ColorId=3,ModelYear=2021,DailyPrice=500,Description="Kazasız"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int Id)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {

            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
