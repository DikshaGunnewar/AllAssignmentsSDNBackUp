using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CountryStateNew.Models
{
    public class Employee12
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required, Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        [Required, Display(Name = "Email Address")]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Birthdate { get; set; }

        

        [Required, Display(Name = "Country")]
        public string Country { get; set; }

        [Required, Display(Name = "State")]
        public string State { get; set; }

        [Required, Display(Name = "Address")]
        public string Address { get; set; }
    }
}