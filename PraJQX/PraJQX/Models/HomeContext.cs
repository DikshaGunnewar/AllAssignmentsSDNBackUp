using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PraJQX.Models
{
    public class HomeContext: DbContext
    {
   public     DbSet<Customer> Customers { get; set; }
      public  DbSet<Order> Orders { get; set; }
      public  DbSet<Product> Products { get; set; }

        public HomeContext() : base("MyConnectionString")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>()
                  .HasKey(t => t.CustomerId)
                 .HasKey(t => new { t.CustomerId, t.CustomerName })
                 .Property(t => t.CustomerName)
                  .IsRequired();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>()
              .Property(t => t.CustomerNumber)
              .IsRequired();


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>()
                .Property(t => t.CustomerEmail)
                .IsRequired();


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>()
                .HasKey(t => t.OrderId);



            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasKey(t => t.ProductId);



        }
    }