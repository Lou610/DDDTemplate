using Assessment.DataAccessLayer.Builder;
using Assessment.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assessment.DataAccessLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? connectionString = ConnectionBase.ConnectionStringBuilder()!;
            //Adds all of the options needed for migration
            var options = new DbContextOptionsBuilder<AssessmentDBContext>()
                .UseSqlServer(connectionString)
                .Options;

            //Builds the context that will be used to deploy the Migration

            using (var context = new AssessmentDBContext(options))
            {
                var migrator = context.Database.GetService<IMigrator>();

                migrator.Migrate(); // This will apply all pending migrations
            }
        }



    }
}