using EfCore.Inheritance.Entity.TPH;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Inheritance.Infrastructure.EFMaps
{
    public class CustomerTphMap : IEntityTypeConfiguration<CustomerTph>
    {
        public void Configure(EntityTypeBuilder<CustomerTph> builder)
        {
            builder.Property(x => x.DateOfBirth).HasColumnName("date_of_birth");
        }
    }
}