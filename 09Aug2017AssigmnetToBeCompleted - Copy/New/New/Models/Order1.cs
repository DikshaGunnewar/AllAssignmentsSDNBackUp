using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace New.Models
{
    public class Order1
    {
        public int OrderId { get; set; }
        public string OrderedItem { get; set; }
        public int OrderedQuantity { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public int? ProductId { get; set; }
        public virtual Customer1 Customer { get; set; }
        public virtual ICollection<Product1> Products { get; set; }*/
    }
}