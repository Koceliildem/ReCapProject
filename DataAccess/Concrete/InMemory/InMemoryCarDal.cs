using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1,BrandId=1,ColorId=231,DailyPrice=23456,ModelYear=1994,Description="TOFAŞ Şahin"},
                new Car{Id=2,BrandId=2,ColorId=21,DailyPrice=25456,ModelYear=1996,Description="TOFAŞ Doğan"},
                new Car{Id=3,BrandId=2,ColorId=4,DailyPrice=15256,ModelYear=1995,Description="TOFAŞ Kartal" },
                new Car{Id=4,BrandId=1,ColorId=31,DailyPrice=18456,ModelYear=1993,Description="TOFAŞ Murat"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int ColorId)
        {
            return _cars.Where(c => c.ColorId == ColorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;

        }
    }
}
