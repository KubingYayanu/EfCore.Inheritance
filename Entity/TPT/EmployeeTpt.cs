using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCore.Inheritance.Entity.TPT
{
    public class EmployeeTpt
    {
        //[ForeignKey(nameof(Person))]
        public Guid Id { get; set; } // PK and FK pointing to PersonTpt

        public PersonTpt Person { get; set; }

        public decimal Turnover { get; set; }
    }
}