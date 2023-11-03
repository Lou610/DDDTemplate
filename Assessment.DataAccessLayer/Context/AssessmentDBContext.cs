
using Microsoft.EntityFrameworkCore;
using Assessment.DataAccessLayer.Configuration;
using Assessment.DataAccessLayer.Models.SET;
using Assessment.DataAccessLayer.Data;

namespace Assessment.DataAccessLayer.Context
{
    public class AssessmentDBContext : DbContext
    {
        ConfigurationHelper configuration = new ConfigurationHelper();


        public AssessmentDBContext(DbContextOptions<AssessmentDBContext> options)
       : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = string.Empty;

            ConnectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(ConnectionString);
        }

        // DbSets for your entities
        public DbSet<Settings> Settings { get; set; }

        // ...other DbSets for other tables

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Model configuration goes here

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.ToTable("Settings", "SET");
                // ... other configurations ...
            });

#if DEBUG
            Seed.SeedData(modelBuilder);
#endif
        }
    }
}
