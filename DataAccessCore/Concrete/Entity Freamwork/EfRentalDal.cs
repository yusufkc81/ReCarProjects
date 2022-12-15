using Core.DataAccess.Entitiy_Freamwork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.Entity_Freamwork
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCarContext>, IRentalDal
    {
        public List<RentalDTO> GetRentalDTOs()
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             join u in context.Users
                             on r.UserId equals u.Id
                             select new RentalDTO()
                             {
                                 Id = r.RentalId,
                                 BrandName = b.Name,
                                 FullName = u.FirstName + " " + u.LastName,
                                 RentTime = r.RenTime,
                                 ReturnTime = r.ReturnTime
                             };
                return result.ToList();
            }
        }

    }
}
