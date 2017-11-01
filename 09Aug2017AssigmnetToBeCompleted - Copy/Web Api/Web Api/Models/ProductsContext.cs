using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_Api.Models
{
    public class ProductsContext:DbContext
    {
        public  ProductsContext():base("name=ProductContext")
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}