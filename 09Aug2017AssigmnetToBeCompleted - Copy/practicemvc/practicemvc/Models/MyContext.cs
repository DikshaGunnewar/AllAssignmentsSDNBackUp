using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace practicemvc.Models
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=mystring")
        {

        }
        public DbSet<dbase> dbases { get; set; }
        public DbSet<MemberType> MemberTypes { get; set; }
    }
}