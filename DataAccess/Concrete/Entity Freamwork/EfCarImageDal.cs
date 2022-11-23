using Core.DataAccess.Entitiy_Freamwork;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Entity_Freamwork
{
    public class EfCarImageDal: EfEntityRepositoryBase<CarImages,ReCarContext>,ICarImageDal
    {

    }
}
