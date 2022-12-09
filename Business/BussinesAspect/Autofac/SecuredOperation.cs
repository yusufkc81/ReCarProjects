using Business.Constants;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.IoC;
using Core.Utilities.Interceptors;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace Business.BussinesAspect.Autofac
{
    public class SecuredOperation:MethodInterception
    {
        //http gelen istek
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;

       
        public SecuredOperation(string roles)
        {
            //servicettolu kullanarak depdencyleri yakalamk için yazılan service
            //rolleri belirleyip rolüne göre seçip çağğırması
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            //önünde çalıştır metodu
            //rollerin claimlerini yani roller bul
            //iglili rolü çalıştır rol yoksa yetkin yok mesajı ver
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
                throw new Exception(Messages.AuthorizationDenied);

            }
        }
    }
}
