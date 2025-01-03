﻿// Listing 32.8 The contents of the DataContext.cs file in the Models folder

using Microsoft.EntityFrameworkCore;

namespace Advanced.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) 
            : base(opts) { }

        public DbSet<Person> People => Set<Person>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Location> Locations => Set<Location>();
    }
}
