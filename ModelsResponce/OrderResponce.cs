using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_Jewelry.ModelsResponce
{
    public class OrderResponce
    {
        public int IdOrder { get; set; }
        public int ClientID { get; set; }
        public DateTime DateOrder { get; set; }
        public int CountOrder { get; set; }
        public int MasterOrder { get; set; }
        public int OrderCost { get; set; }
        public int ProductsID { get; set; }

    }
}
