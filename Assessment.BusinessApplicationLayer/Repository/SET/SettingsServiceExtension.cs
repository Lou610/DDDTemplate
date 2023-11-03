using Assessment.BusinessApplicationLayer.Repository.SET.Interface;
using Assessment.DataAccessLayer.Interfaces;
using Assessment.DataAccessLayer.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.BusinessApplicationLayer.Repository.SET
{
    public static class SettingsServiceExtension
    {
        public static IServiceCollection AddSetting(this IServiceCollection services)
        {
            services.AddScoped<ISettingsService, SettingsService>();

            return services;
        }
    }
}
