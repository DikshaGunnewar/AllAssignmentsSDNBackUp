using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PraJQX.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public long CustomerNumber { get; set; }

        ICollection<Order> Order { get; set; }
    }
}