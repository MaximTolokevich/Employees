﻿using Employees.Models;
using Microsoft.EntityFrameworkCore;

namespace Employees.Context
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployeeContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Employee;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
