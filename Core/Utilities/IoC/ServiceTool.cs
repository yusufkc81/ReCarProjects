using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core.IoC
{
    public static class ServiceTool
    {
        //oluşan injectionların oluşmasını sağlaayan metot servicdeki karşılığı alabiliriz
        //aspect olduğu için confirge edemiyoruz o yüzden böyle bir service yapıyoruz
        //configire ettiğimizi jwthelper da göebilirisin

        public static IServiceProvider ServiceProvider { get;private set; }
        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider =services.BuildServiceProvider();
            return services;
        }
    }
}
