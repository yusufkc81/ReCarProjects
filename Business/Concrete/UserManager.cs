using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Freamwork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userdal;
        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }       


        public void Add(User user)
        {
            _userdal.Add(user);
        }

        public User GetByMail(string email)
        {
           return _userdal.Get(c=>c.Email==email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
           return _userdal.GetClaims(user);
        }
    }
}
