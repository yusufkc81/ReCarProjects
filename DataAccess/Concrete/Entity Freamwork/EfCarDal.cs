using Core.DataAccess.Entitiy_Freamwork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;

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
                             select new CarDTO
                             {
                                 BrandName = c.Name,
                                 CategoryName = d.Name,
                                 DailyPrice = p.DailyPrice,
                                 Description = p.Description,
                                 Id=p.Id  
                             };

                return result.ToList();
            }
        }
    }
}

