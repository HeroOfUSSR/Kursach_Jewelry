using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_Jewelry.Models
{
    public class Order
    {
        public int IdOrder { get; set; }
        public int ClientID { get; set; }
        public DateTime DateOrder { get; set; }
        public int CountOrder { get; set; }
        public int MasterOrder { get; set; }
        public int OrderCost { get; set; }
        public int ProductsID { get; set; }


        public virtual Client client { get; set; }
        public virtual Master master { get; set; }
        public virtual Product product { get; set; }

    }
}
