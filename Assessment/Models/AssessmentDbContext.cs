using Assessment.Models.DBO;
using Microsoft.EntityFrameworkCore;
using System;

namespace Assessment.Models
{
    public class AssessmentDbContext : DbContext
    {
        public DbSet<MigrationTest> MigrationTest { get; set; }

        public AssessmentDbContext(DbContextOptions<AssessmentDbContext> options) : base(options)
        {
        }
    }
}
