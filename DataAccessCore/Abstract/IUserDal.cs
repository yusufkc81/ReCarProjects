using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        //join işlemi için join işleminide claimleerinide çekmemiz gerekiyor kullanıcya göre rol değişimi olucak
        List<OperationClaim> GetClaims(User user);
    }
}
