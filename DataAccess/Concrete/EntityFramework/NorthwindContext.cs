using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{ //Context: Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        //Bu method ile hangi veritabanı ile ilişkilendireceğimizi belirteceğiz
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        //DbSet ile hangi Class hangi Tabloya denk geldiğini belirtmek için
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
