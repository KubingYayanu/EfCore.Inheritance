using EfCore.Inheritance.Enum;
using System;

namespace EfCore.Inheritance.Entity.TPH
{
    public class PersonTph
    {
        public Guid Id { get; set; }

        public PersonTphTypeEnum PersonType { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}