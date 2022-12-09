using Core.Entities.Concrete;
using Core.Utilities;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForloginDto userForloginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user); 
    }
}
