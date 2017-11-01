using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practicemvc.Models
{
    public class NewDataViewModel
    {
        public IEnumerable<MemberType> MemberTypes { get; set; }
        public dbase dbase { get; set; }
    }
}