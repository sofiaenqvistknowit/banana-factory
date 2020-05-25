using Microsoft.EntityFrameworkCore;
using System;
using BananaFactory.Model;


namespace BananaFactory.Repository
{
    public class BananaFactoryDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Order { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=BananaFactory;trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasKey(c => new {c.CustomerID});
            modelBuilder.Entity<Customer>()
                .Property(c => c.CustomerID)
                .ValueGeneratedOnAdd();


            modelBuilder.Entity<Order>()
                .HasKey(o => new { o.OrderID });
            modelBuilder.Entity<Order>()
                .Property(o => o.OrderID)
                .ValueGeneratedOnAdd();


            modelBuilder.Entity<OrderProduct>()
                .HasKey(o => new { o.OrderProductID });
            modelBuilder.Entity<OrderProduct>()
                .Property(o => o.OrderProductID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .HasKey(o => new { o.ProductID });
            modelBuilder.Entity<Product>()
                .Property(o => o.ProductID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Supplier>()
                .HasKey(o => new { o.SupplierID });
            modelBuilder.Entity<Supplier>()
                .Property(o => o.SupplierID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Image>()
                .HasKey(o => new { o.ImageID });
            modelBuilder.Entity<Image>()
                .Property(o => o.ImageID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<ProductType>()
                .HasKey(o => new { o.ProductTypeID });
            modelBuilder.Entity<ProductType>()
                .Property(o => o.ProductTypeID)
                .ValueGeneratedOnAdd();
        }
    }
}
