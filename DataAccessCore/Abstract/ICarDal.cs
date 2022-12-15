using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal: IEntityRepository<Cars>
    {
        List<CarDTO> GetCarDTOs();
    }
}
