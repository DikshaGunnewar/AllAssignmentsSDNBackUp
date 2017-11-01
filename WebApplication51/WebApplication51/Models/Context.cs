using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication51.Models
{
    public class Context : DbContext
    {
       public Context() : base("name=MyConnectionString")
        {

        }
        public DbSet<Student> students { get; set; }
        public DbSet<StudentDetail> studentDetails { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>()
        //       .HasKey(o => o.Id);

        //    modelBuilder.Entity<StudentDetail>()
        //       .HasKey(o => o.Id);

        //    modelBuilder.Entity<StudentDetail>()
        //            .HasRequired(o => o.student)
        //            .WithRequiredDependent(o => o.studentdetail);

        //    base.OnModelCreating(modelBuilder);
        //}
        public static Context Create()
        {
            return new Context();
        }

    }
}