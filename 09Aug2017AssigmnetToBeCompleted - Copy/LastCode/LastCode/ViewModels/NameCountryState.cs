using LastCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LastCode.ViewModels
{
    public class NameCountryState
    {
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<State> States { get; set; }
        public Customer Customer { get; set; }
    }
}