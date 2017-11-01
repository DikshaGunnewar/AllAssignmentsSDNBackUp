using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace New.Models
{
    public class CustomerContext:DbContext
    {
        public CustomerContext():base("name= CustomerContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer1>()
                .HasKey(c => c.CustomerId);
            modelBuilder.Entity<Product1>()
                .HasKey(c => c.ProductId);
            modelBuilder.Entity<Order1>()
                .HasKey(c => c.OrderId);

            //The customerId is Indentity
            /*  modelBuilder.Entity<Customer>()
                  .Property(c => c.CustomerId)
                  .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);  

              modelBuilder.Entity<Customer>()
                  .Property(c => c.CustomerName)
                  .HasMaxLength(80);

              modelBuilder.Entity<Order>()
                  .HasKey(o => o.OrderId);

              //The OrderId is Indentity
              modelBuilder.Entity<Order>()
                  .Property(o =>o.OrderId)
                  .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

              //Foreign Key for the Order Table by the CustomerId
              modelBuilder.Entity<Order>()
                  .HasRequired(c => c.Customer)
                  .WithMany(o => o.Orders).HasForeignKey(o => o.CustomerId);

              //The Cascade Delete from Customer to Orders
              modelBuilder.Entity<Order>()
               .HasRequired(c => c.Customer)
               .WithMany(o => o.Orders)
               .HasForeignKey(o => o.CustomerId)
               .WillCascadeOnDelete(true);



              //Foreign Key for the Customer Table by the ProductId
              modelBuilder.Entity<Customer>()
                 .HasRequired<Product>(s => s.Product)
                 .WithMany(t => t.Customers)
                 .HasForeignKey(u => u.ProductId);*/


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product1> ProductsList { get; set; }
        public DbSet<Order1> OrdersList { get; set; }
        public DbSet<Customer1> CustomersList { get; set; }
    }
}