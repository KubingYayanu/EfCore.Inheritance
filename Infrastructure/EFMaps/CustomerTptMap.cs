using EfCore.Inheritance.Entity.TPT;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Inheritance.Infrastructure.EFMaps
{
    public class CustomerTptMap : IEntityTypeConfiguration<CustomerTpt>
    {
        public void Configure(EntityTypeBuilder<CustomerTpt> builder)
        {
            builder.ToTable("CustomerTpt");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.DateOfBirth).HasColumnName("date_of_birth");

            builder.HasOne(x => x.Person)
                .WithOne()
                .HasForeignKey<CustomerTpt>(x => x.Id);
        }
    }
}