using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_Jewelry.BD
{
    public class SampleContextFactory : IDesignTimeDbContextFactory<DbContextJewelry>
    {
        public DbContextJewelry CreateDbContext(string[] args)
     => new DbContextJewelry(DataBaseHelper.Option());
    }
}
