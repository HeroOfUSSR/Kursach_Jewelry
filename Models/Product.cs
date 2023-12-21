﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_Jewelry.Models
{
    public class Product
    {
        public int IDProducts { get; set; }
        public string NameProduct { get; set; }
        public int PriceProduct { get; set; }
        public string TypeProduct { get; set; }
        public int CountProduct { get; set; }
        public int MaterialID { get; set; }



        public virtual ICollection<Order> Orders { get; set; }

        public virtual Material Material { get; set; }
    }
}
