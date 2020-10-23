using EfCore.Inheritance.Entity.TPH;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Inheritance.Infrastructure.EFMaps
{
    public class EmployeeTphMap : IEntityTypeConfiguration<EmployeeTph>
    {
        public void Configure(EntityTypeBuilder<EmployeeTph> builder)
        {
            builder.Property(x => x.Turnover).HasColumnName("turnover");
        }
    }
}