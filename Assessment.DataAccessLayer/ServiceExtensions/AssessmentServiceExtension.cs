using Assessment.DataAccessLayer.Builder;
using Assessment.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.DataAccessLayer.ServiceExtensions
{
    public static class AssessmentServiceExtension
    {
        public static IServiceCollection AddAssessmentContext(this IServiceCollection services)
        {
            services.AddDbContext<AssessmentDBContext>(options =>
            {
                options.UseSqlServer(ConnectionBase.ConnectionStringBuilder());
            }); 

            return services;
        }
    }
}
