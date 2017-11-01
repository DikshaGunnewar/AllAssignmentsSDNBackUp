using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LastCode.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }


        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Birthdate { get; set; }
        public string Address { get; set; }
        [DisplayName("Country")]
        public string CountryName { get; set; }
        [DisplayName("State")]
        public string StateName { get; set; }
    }
}