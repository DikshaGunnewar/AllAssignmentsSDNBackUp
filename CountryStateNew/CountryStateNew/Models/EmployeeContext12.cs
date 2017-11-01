using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CountryStateNew.Models
{
    public class EmployeeContext12:DbContext
    {
        public EmployeeContext12():base("name= EmployeeContext12")
        {

        }
        public DbSet<Employee12> EmpList { get; set; }
        public DbSet<Country12> CountryList { get; set; }
        public DbSet<State12> StateList { get; set; }
        
    }
}