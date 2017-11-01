using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DikshaAssignment3.Models
{
    public class StudentContext1: DbContext
    {
        public  StudentContext1():base("name= StudentContext1") { }
        public DbSet<Student1> Student1s { get; set; }
    }
}