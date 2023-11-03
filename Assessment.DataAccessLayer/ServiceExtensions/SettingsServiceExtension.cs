using Assessment.DataAccessLayer.Interfaces;
using Assessment.DataAccessLayer.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.DataAccessLayer.ServiceExtensions
{
    public static class SettingsServiceExtension
    {
        public static IServiceCollection AddSettingContext(this IServiceCollection services)
        {
            services.AddAssessmentContext();

            services.AddScoped<ISettingsRepository, SettingsRepository>();

            return services;
        }
    }
}
