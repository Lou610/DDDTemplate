using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.DataAccessLayer.Models.SET
{
    public class SettingsConfigutation
    {
        public void Configure(EntityTypeBuilder<Settings> entity)
        {

            entity.ToTable("Settings","SET");

            entity.Property(e => e.SettingName)
                .HasColumnType("nvarchar(250)");
            entity.Property(e => e.SettingValue)
                .HasColumnType("nvarchar(250)");
            entity.Property(e => e.IsEnabled)
                .HasColumnType("bit");
        }
    }
}
