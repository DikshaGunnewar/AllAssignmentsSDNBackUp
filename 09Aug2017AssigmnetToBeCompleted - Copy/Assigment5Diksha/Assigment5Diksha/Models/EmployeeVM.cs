using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assigment5Diksha.Models
{
    public class EmployeeVM
    {
        [Key]
        public int Id { get; set; }
        public Employee Employees { get; set; }    
        public IEnumerable<State> States { get; set; }
        public IEnumerable<City> Citys { get; set; }
    }
}