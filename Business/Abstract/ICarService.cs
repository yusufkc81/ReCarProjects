using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService  
    {
        IDataResult<List<Cars>> GetAll();
        IDataResult<List<Cars>> GetBrandId(int id);
        IDataResult<List<Cars>> GetColorId(int id);
        IResult Add(Cars car);
        IResult Update(Cars car);
        IResult Delete(Cars car);
    }
}
