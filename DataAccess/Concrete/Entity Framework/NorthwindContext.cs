using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database = MyRentACar;Trusted_Connection=true;");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }

        // custom mapping 
        // personel i Employee ye baglama

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Personel>().ToTable("Employees","dbo"); // sonda dbo yazmamizin sebebi hangi dosya turu oldugu 
        //    //eger baska bir dosya turuyse onu yaziniz
        //    modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeID"); //column name olarak db de ne uyaziyosa onu yazicaz
        //    modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
        //    modelBuilder.Entity<Personel>().Property(p => p.Surname).HasColumnName("LastName");
        //}
    }
}
