using New.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace New.Models
{
    public class Customer1
    {
        public int CustomerId { get; set; }
        // public int ProductId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public virtual Product1 Product { get; set; }

        public virtual ICollection<Order1> Orders { get; set; }
        public virtual ICollection<Product1> Products { get; set; }
    }
}