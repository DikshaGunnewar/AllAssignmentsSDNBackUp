using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assigment5Diksha.Models
{
    public class Employee1Context:DbContext
    {
        public Employee1Context():base("name= EmployeeContext")
        {

        }

        public DbSet<Employee> EmpList { get; set; }
        public DbSet<State> StateList { get; set; }
        public DbSet<City> CityList { get; set; }

        public System.Data.Entity.DbSet<Assigment5Diksha.Models.EmployeeVM> EmployeeVMs { get; set; }

       
    }
}