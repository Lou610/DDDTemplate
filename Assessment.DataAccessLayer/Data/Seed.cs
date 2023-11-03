using Assessment.DataAccessLayer.Models.SET;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.DataAccessLayer.Data
{
    public class Seed
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Settings>().HasData(
                new Settings
                {
                    Id = -1,
                    SettingName = "Setting Name here",
                    SettingValue = "Setting Value here",
                    
                }

            // Add more events as needed
            );
        }
    }
}
