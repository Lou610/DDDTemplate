using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.DataAccessLayer.ServiceExtensions
{
    public static class DataAccessLayerServiceExtension
    {
        public static IServiceCollection AddDALContext(this IServiceCollection services)
        {
            services.AddSettingContext();
            return services;
        }
    }
}
