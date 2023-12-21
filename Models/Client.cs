using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_Jewelry.Models
{
    public class Client
    {

        public int IdClient { get; set; }
        public string NameClient { get; set; }
        public string PhoneClient { get; set; }
        public int OrderClient { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
