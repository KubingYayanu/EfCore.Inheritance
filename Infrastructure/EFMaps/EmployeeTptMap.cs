using EfCore.Inheritance.Entity.TPT;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Inheritance.Infrastructure.EFMaps
{
    public class EmployeeTptMap : IEntityTypeConfiguration<EmployeeTpt>
    {
        public void Configure(EntityTypeBuilder<EmployeeTpt> builder)
        {
            builder.ToTable("EmployeeTpt");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Turnover).HasColumnName("turnover");

            builder.HasOne(x => x.Person)
                .WithOne()
                .HasForeignKey<EmployeeTpt>(x => x.Id);
        }
    }
}