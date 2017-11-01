using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DikshaAssignment3.Models
{
    public class Student1
    {
        public int ID{ get; set; }
        [Required]
        [Display(Name = "Name")]
        [StringLength(20, ErrorMessage = "Name not be exceed 20 char")]
        public string Name { get; set; }
        [Display(Name = " Email")]
        [Required(ErrorMessage = "Email_id must not be empty")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required]
        [Display(Name = " Age")]
        public int Age { get; set; }
        [Display(Name = " Qualifications")]
        public string Qualification { get; set; }
        
        public string MaritialStatus { get; set; }
    }
}