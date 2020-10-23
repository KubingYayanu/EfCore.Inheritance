using EfCore.Inheritance.Entity.TPH;
using EfCore.Inheritance.Entity.TPT;
using EfCore.Inheritance.Enum;
using EfCore.Inheritance.Infrastructure;
using System;
using System.Linq;

namespace EfCore.Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Tph();
        }

        private static void Tht()
        {
            using (var context = new TptDbContext())
            {
                var people = context.People.ToList();
                var customers = context.Customers.ToList();
                var employees = context.Employees.ToList();

                context.Customers.Add(new CustomerTpt
                {
                    Person = new PersonTpt
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "KK",
                        LastName = "kk"
                    },
                    DateOfBirth = DateTime.Now
                });

                context.SaveChanges();
            }
        }

        private static void Tph()
        {
            using (var context = new TphDbContext())
            {
                var people = context.People.ToList();
                var customers = context.Customers.ToList();
                var employees = context.Employees.ToList();

                context.Employees.Add(new EmployeeTph
                {
                    Id = Guid.NewGuid(),
                    PersonType = PersonTphTypeEnum.Employee,
                    FirstName = "EE",
                    LastName = "ee",
                    Turnover = 120
                });

                context.SaveChanges();
            }
        }
    }
}