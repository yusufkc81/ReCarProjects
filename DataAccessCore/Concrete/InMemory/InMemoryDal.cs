using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : ICarDal
    {
        List<Cars> cars;
        public InMemoryDal()
        {
            cars = new List<Cars>() {
            new Cars { BrandId = 1, ColorId = 1, DailyPrice = 300, Description = "Hyndaui", Id = 1, ModelYear = "2016" },
            new Cars { BrandId = 1, ColorId = 1, DailyPrice = 200, Description = "Honda", Id = 2, ModelYear = "2020" },
            new Cars { BrandId = 2, ColorId = 2, DailyPrice = 250, Description = "Reunalt", Id = 3, ModelYear = "2018" },
            new Cars { BrandId = 3, ColorId = 3, DailyPrice = 350, Description = "Fiat", Id = 4, ModelYear = "2022" },
            new Cars { BrandId = 3, ColorId = 3, DailyPrice = 370, Description = "Ford", Id = 5, ModelYear = "2022" }
                                   };
        }
        public void Add(Cars car)
        {
            cars.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars carDelete = cars.SingleOrDefault(c => c.Id == car.Id);
            cars.Remove(carDelete);
        }

        public Cars Get(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }


        public List<Cars> GetAll(Func<object, bool> value)
        {
            return cars;
        }

        public List<Cars> GetAll()
        {
            throw new NotImplementedException();
        }


        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetById(int id)
        {
            return cars.Where(c => c.Id == id).ToList();
        }

        public List<CarDTO> GetCarDTOs()
        {
            throw new NotImplementedException();
        }

        public void Update(Cars car)
        {
            Cars carUpdate = cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.Id = car.Id;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
        }
    }
}

