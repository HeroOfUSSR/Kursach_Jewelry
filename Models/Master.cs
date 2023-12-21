using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_Jewelry.Models
{
    public class Master
    {

        public int IdMaster { get; set; }
        public string NameMaster { get; set; }
        public string PhoneMaster { get; set; }
        public int OrderMaster { get; set; }


        public virtual ICollection<Order> Orders { get; set; }


    }
}
