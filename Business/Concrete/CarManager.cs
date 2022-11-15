using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Freamwork;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService

    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public void Add(Cars car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _CarDal.Add(car);
                Console.WriteLine("Başarılı ile Eklendi");
            }
            else
            {
                Console.WriteLine("Araba ismini 2 harfden az yazmazsınız veya günlük fiyatı 0 dan küçük olamaz");

            }

        }

        public void Delete(Cars car)
        {
            _CarDal.Delete(car);
            Console.WriteLine("Başarı ile Silindi");
        }

        public List<Cars> GetAll()
        {

            return _CarDal.GetAll();

            //Console.WriteLine("Başarı ile Listelendi");
        }

        public List<Cars> GetBrandId(int id)
        {
            return _CarDal.GetAll(x => x.BrandId == id);
        }

        public List<Cars> GetColorId(int id)
        {
            return _CarDal.GetAll(x => x.ColorId == id);
        }

        public void Update(Cars car)
        {
            _CarDal.Update(car);
            Console.WriteLine("Başarı ile Güncelle");
        }
    }
}
