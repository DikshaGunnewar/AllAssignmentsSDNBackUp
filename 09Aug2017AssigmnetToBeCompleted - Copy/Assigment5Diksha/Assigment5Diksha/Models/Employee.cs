using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assigment5Diksha.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required, Display(Name = "Enter Name")]
        public string EmployeeName { get; set; }

        [Display(Name = " Email")]
        [Required(ErrorMessage = "Email_id must not be empty")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }



        [Required, Display(Name = "Phone")]
        public string PhoneNo { get; set; }


        [Required]
        public bool MaritialStatus { get; set; }


        [Required, Display(Name = "State")]
        public int State { get; set; }

        [Required, Display(Name = "City")]
        public int City { get; set; }
      
    }
}