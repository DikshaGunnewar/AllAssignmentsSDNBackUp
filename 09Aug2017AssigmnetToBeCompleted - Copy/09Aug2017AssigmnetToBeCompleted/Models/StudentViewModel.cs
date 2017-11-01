using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _09Aug2017AssigmnetToBeCompleted.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public int RollNo { get; set; }
        public int Id { get; set; }
      
        public string Address { get; set; }
        public long MobileNo { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}