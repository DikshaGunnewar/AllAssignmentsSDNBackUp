using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CountryStateNew.Models
{
    public class Country12
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
      //  public string Abbr { get; set; }
    }
}