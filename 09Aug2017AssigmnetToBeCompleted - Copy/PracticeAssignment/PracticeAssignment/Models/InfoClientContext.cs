using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticeAssignment.Models
{
    public class InfoClientContext:DbContext
    {
        public InfoClientContext():base("name= InfoClientContext")
        {

        }
        public DbSet<InfoClient> InfoClients { get; set; }
        public DbSet<State> StateList { get; set; }
        public DbSet<City> CityList { get; set; }
    }
}