using System;

namespace EfCore.Inheritance.Entity.TPH
{
    public class CustomerTph : PersonTph
    {
        public DateTime DateOfBirth { get; set; }
    }
}