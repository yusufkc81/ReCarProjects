using Core.DataAccess.Entitiy_Freamwork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.Entity_Freamwork
{
    public class EfCarDal : EfEntityRepositoryBase<Cars, ReCarContext>, ICarDal
    {
        public List<CarDTO> GetCarDTOs()
        {
            using (ReCarContext context=new ReCarContext())
            {
                var result = from p in context.Cars
                             join c in context.Brand
                             on p.BrandId equals c.BrandId
                             join d in context.Color
                             on p.ColorId equals d.ColorId
                             join img in context.CarImages
                             on p.Id equals img.CarId
                             select new CarDTO
                             {
                                 ImagePath=img.ImagePath,
                                 BrandId=p.BrandId,
                                 BrandName = c.Name,
                                 ColorId=p.ColorId,
                                 ColorName = d.Name,
                                 DailyPrice = p.DailyPrice,
                                 Description = p.Description,
                                 ModelYear = p.ModelYear,
                                 Id=p.Id,
                             };

                return result.ToList();
            }
        }
    }
}

