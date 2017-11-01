using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace New.Models
{
    public class Product1
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int OrderId { get; set; }
        //public int? CustomerId { get; set; }
        /* public virtual Order Order { get; set; }
         public virtual Customer Customer { get; set; }
         public virtual ICollection<Customer> Customers { get; set; }*/
    }
}