﻿// Listing 32.5 the contents of hte Person.cs file in the Models folder

namespace Advanced.Models
{
    public class Person
    {
        public long PersonId { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public long DepartmentId { get; set; }
        public long LocationId { get; set; }

        public Department? Department { get; set; }
        public Location? Location { get; set; }
    }
}
