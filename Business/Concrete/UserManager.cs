using Business.Abstract;
using Business.Constants;
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
    public class UserManager:IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.AddedUser);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.DeletedUser);
        }

        public IDataResult<List<User>> GetAll()
        {

            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<List<User>> GetCustomerId(int id)
        {
            
           return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.CustomerId == id));

        }
        
        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UpadateUser);
        }
    }
}
