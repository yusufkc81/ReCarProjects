using Core.DataAccess.Entitiy_Freamwork;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.Entity_Freamwork
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCarContext>, ICustomerDal
    {
    }
}
