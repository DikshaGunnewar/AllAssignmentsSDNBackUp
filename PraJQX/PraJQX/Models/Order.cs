using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PraJQX.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderTotalPrice { get; set; }
        public string CustomerName { get; set; }
        public Customer customer { get; set; }
        ICollection<Product> product { get; set; }
    }
}