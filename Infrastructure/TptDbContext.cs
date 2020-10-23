using EfCore.Inheritance.Entity.TPT;
using EfCore.Inheritance.Infrastructure.EFMaps;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Inheritance.Infrastructure
{
    public class TptDbContext : DbContext
    {
        public DbSet<PersonTpt> People { get; set; }
        public DbSet<CustomerTpt> Customers { get; set; }
        public DbSet<EmployeeTpt> Employees { get; set; }

        public TptDbContext()
        {
        }

        public TptDbContext(DbContextOptions<TptDbContext> options)
          : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=TPT;User ID=dev;Password=sa;Max Pool Size=1024;MultipleActiveResultSets=True;Connect Timeout=2;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonTptMap());
            modelBuilder.ApplyConfiguration(new CustomerTptMap());
            modelBuilder.ApplyConfiguration(new EmployeeTptMap());
        }
    }
}