using EfCore.Inheritance.Entity.TPH;
using EfCore.Inheritance.Infrastructure.EFMaps;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Inheritance.Infrastructure
{
    public class TphDbContext : DbContext
    {
        public DbSet<PersonTph> People { get; set; }
        public DbSet<CustomerTph> Customers { get; set; }
        public DbSet<EmployeeTph> Employees { get; set; }

        public TphDbContext()
        {
        }

        public TphDbContext(DbContextOptions<TphDbContext> options)
          : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=TPH;User ID=dev;Password=sa;Max Pool Size=1024;MultipleActiveResultSets=True;Connect Timeout=2;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonTphMap());
            modelBuilder.ApplyConfiguration(new CustomerTphMap());
            modelBuilder.ApplyConfiguration(new EmployeeTphMap());
        }
    }
}