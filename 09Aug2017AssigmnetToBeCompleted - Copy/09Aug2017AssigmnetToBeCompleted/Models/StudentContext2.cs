using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _09Aug2017AssigmnetToBeCompleted.Models
{
    public class StudentContext2:DbContext
    {
        public StudentContext2() : base("name=StudentContext2")
        {

        }
       
      public DbSet<Student2> Students { get; set; }
      public DbSet<StudentDetails2> StudentDetails { get; set; }

      public DbSet<StudentViewModel> StudentViewModels { get; set; }
    }

}