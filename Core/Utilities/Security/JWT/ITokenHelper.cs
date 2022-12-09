using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //token üretimi ve görevli listesenine refleme
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
