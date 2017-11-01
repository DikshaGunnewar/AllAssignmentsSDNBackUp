using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _09Aug2017AssigmnetToBeCompleted.Models
{
    public class StudentDetails2
    {
       
        [Key]
        public int studId { get; set; }       
        public string Address { get; set; }
        public long MobileNo { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int StudentId { get; set; }
        public Student2 Student { get; set; }
    }
}