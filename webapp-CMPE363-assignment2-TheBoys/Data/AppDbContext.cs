using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using webapp_CMPE363_assignment2_TheBoys.Models;

namespace webapp_CMPE363_assignment2_TheBoys.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public IDbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("tblEmployee");
        }
    }
}