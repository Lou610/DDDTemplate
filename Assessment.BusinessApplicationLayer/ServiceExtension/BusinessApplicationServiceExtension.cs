using Assessment.BusinessApplicationLayer.Repository.SET;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.BusinessApplicationLayer.ServiceExtension
{
    public static class BusinessApplicationServiceExtension
    {
        public static IServiceCollection AddBALManagement(this IServiceCollection services)
        {
            services.AddSetting();
            return services;
        }
    }
}
