using System.Data.Entity;

namespace Grid.Models
{
    public class OrderContext:DbContext
    {
        public  OrderContext():base("name= OrderContext")
        {
        }
        public DbSet<Order11>Order11s { get; set; }
    }
}