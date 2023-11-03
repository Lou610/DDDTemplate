using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Models.DBO
{
    public class MigrationTestConfiguration
    {
        public void Configure(EntityTypeBuilder<MigrationTest> builder)
        {
            builder.ToTable("MigrationTest", "DBO");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").IsRequired();
            builder.Property(x => x.Title).HasColumnName("Title").IsRequired();
            builder.Property(x => x.Author).HasColumnName("Author").IsRequired();
        }
    }
}
