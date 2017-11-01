using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticeAssignment.Models
{
    public class InfoClient
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required, Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        [Required, Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required, Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]

        public DateTime DOB { get; set; }

        [Required, Display(Name = "State")]
        public string State { get; set; }

        [Required, Display(Name = "City")]
        public string City { get; set; }

        [Required, Display(Name = "Address")]
        public string Address { get; set; }

        public byte[] Image { get; set; }
    }
}