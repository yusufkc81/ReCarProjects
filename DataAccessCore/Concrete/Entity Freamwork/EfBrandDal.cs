using Core.DataAccess.Entitiy_Freamwork;
using DataAccess.Abstract;
using Entities.Concrete;


namespace DataAccess.Concrete.Entity_Freamwork
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, ReCarContext>, IBrandDal
    {
    
    }
}
