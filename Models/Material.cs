using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_Jewelry.Models
{
    public class Material
    {
        public int IdMaterials { get; set; }
        public string NameMaterial { get; set; }
        public string ColorMaterial { get; set; }
        public int SampleMaterial { get; set; }

        public virtual ICollection<Product> product { get; set; }
    }
}
