
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;


namespace Core.Extensions
{
    public static class ClaimsPrincipalExtensions
    { 
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal,string claimType)
        {
            //hangi claimtype göre yani claimtype şeyine göre getiroyor
            var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();
            return result;

        }
        //buda sadece rolleri çapırıyor zaten hep rol çağırcam diye
        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }


    }
}
