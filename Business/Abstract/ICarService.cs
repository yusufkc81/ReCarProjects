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
        List<Cars> GetAll();
        List<Cars> GetBrandId(int id);
        List<Cars> GetColorId(int id);
        void Add(Cars car);
        void Update(Cars car);
        void Delete(Cars car);
    }
}
