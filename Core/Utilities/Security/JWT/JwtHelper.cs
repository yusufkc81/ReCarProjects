
using Core.Entities.Concrete;
using Core.Extensions;
using Core.Utilities.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class JwtHelper:ITokenHelper
    {
        //appsettingdeki bilgileri okumak için çağırıyoruz
        public IConfiguration Configuration { get; }
        //
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;

        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
           
        }

        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            //token kaç dakika kalıcağını appsettingde bilgilden alıyor 10 dk yani
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            //appsettingde securitkey al
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            //Hangi anahtarı ve algoritmayı kullanması
            var signingCredentials= SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            //jwt oluşumu için ihtayacımı olan parametlereler oluşumu için metot create
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            //
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };


        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions,User user,SigningCredentials signingCredentials,List<OperationClaim> operationClaim)
        {
            //token oluşumu için eşleme gibi bişi yapıyoruz bu metotu kullanıp işliyoruz yukarda 
            var jwt = new JwtSecurityToken
                (
                issuer:tokenOptions.Issuer,
                audience:tokenOptions.Audience,
                expires:_accessTokenExpiration,
                notBefore:DateTime.Now,
                signingCredentials:signingCredentials
                
                );
            return jwt;

        }


        //Claim listesi oluştursun diye 
        public IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

            return claims;

        }


    }
}
