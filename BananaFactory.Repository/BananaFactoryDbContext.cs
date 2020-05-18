using Microsoft.EntityFrameworkCore;
using System;
using BananaFactory.Model;


namespace BananaFactory.Repository
{
    public class BananaFactoryDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

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
        }
    }
}
