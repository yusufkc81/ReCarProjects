using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetCarId(int id);
        IDataResult<List<Rental>> GetUserId(int id);
        IDataResult<List<RentalDTO>> GetDtos();
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);


    }
}
