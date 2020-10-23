using EfCore.Inheritance.Entity.TPT;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Inheritance.Infrastructure.EFMaps
{
    public class PersonTptMap : IEntityTypeConfiguration<PersonTpt>
    {
        public void Configure(EntityTypeBuilder<PersonTpt> builder)
        {
            builder.ToTable("PersonTpt");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.FirstName).HasColumnName("first_name");
            builder.Property(x => x.LastName).HasColumnName("last_name");
        }
    }
}