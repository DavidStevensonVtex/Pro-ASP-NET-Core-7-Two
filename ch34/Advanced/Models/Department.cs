﻿// Listing 32.6 The contents of the Deprtment.cs file in the Models folder

namespace Advanced.Models
{
    public class Department
    {
        public long Departmentid {  get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable<Person>? People { get; set; }
    }
}
