using Core.DataAccess.Entitiy_Freamwork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Concrete.Entity_Freamwork
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCarContext>, IRentalDal
    {
    }
}
