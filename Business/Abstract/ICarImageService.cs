using Core.Utilities;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImages>> GetAll();
        IResult Add(/*IFormFile file,*/CarImages carImages);
        IResult Delete(/*IFormFile file,*/ CarImages carImages);
        IResult Update(/*IFormFile file,*/CarImages carImages);
        
    }
}
