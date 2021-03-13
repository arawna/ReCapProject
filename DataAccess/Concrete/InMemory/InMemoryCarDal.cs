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
        List<Car> Cars = new List<Car>
        {
            new Car{ CarId=1, BrandId=1, ColorId=3, ModelYear=2012, DailyPrice=53000, Description="Opel Astra"},
            new Car{ CarId=2, BrandId=1, ColorId=1, ModelYear=2021, DailyPrice=65000, Description="Opel Corsa"},
            new Car{ CarId=3, BrandId=2, ColorId=5, ModelYear=2019, DailyPrice=70000, Description="Volvo S60"},
            new Car{ CarId=4, BrandId=3, ColorId=3, ModelYear=2020, DailyPrice=72000, Description="Audi A1"},
            new Car{ CarId=5, BrandId=4, ColorId=2, ModelYear=2009, DailyPrice=25000, Description="Volkswagen Polo"}
        };
        public void Add(Car car)
        {
            Cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = Cars.SingleOrDefault(c => c.CarId == car.CarId);
            Cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return Cars;
        }

        public List<Car> GetById(int carId)
        {
            return Cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUptade = Cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.ModelYear = car.ModelYear;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.Description = car.Description;
        }
    }
}
