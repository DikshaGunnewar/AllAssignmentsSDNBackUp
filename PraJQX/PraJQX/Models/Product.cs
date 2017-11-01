using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PraJQX.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProdcutPrice { get; set; }
        public int Quantity { get; set; }

        ICollection<Order> order { get; set; }
    }
}