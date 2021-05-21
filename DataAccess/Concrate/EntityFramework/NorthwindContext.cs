using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    //Context = db tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        //Hangi veritabanına bağlanacağını ayarladık
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true;"); //server ismi ; sqldeki bağlıcamız tablo ismi; erişim;
        }
        //Hangi class db deki hangi tabloyla ilişkelendirilecek
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
