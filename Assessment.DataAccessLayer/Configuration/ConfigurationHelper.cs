using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.DataAccessLayer.Configuration
{
    public class ConfigurationHelper
    {
        public IConfiguration InitConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            return configuration;
        }

        public string GetConnectionString(string name = "DefaultConnection")
        {
            var configuration = InitConfiguration();
            return configuration.GetConnectionString(name)!;
        }
    }
}
