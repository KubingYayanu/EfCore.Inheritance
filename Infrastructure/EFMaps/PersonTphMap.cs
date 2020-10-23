using EfCore.Inheritance.Entity.TPH;
using EfCore.Inheritance.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Inheritance.Infrastructure.EFMaps
{
    public class PersonTphMap : IEntityTypeConfiguration<PersonTph>
    {
        public void Configure(EntityTypeBuilder<PersonTph> builder)
        {
            builder.ToTable("PersonTph");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.PersonType).HasColumnName("type");
            builder.Property(x => x.FirstName).HasColumnName("first_name");
            builder.Property(x => x.LastName).HasColumnName("last_name");

            builder.HasDiscriminator(x => x.PersonType)
                .HasValue<PersonTph>(PersonTphTypeEnum.Person)
                .HasValue<CustomerTph>(PersonTphTypeEnum.Customer)
                .HasValue<EmployeeTph>(PersonTphTypeEnum.Employee);
        }
    }
}