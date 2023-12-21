using Kursach_Jewelry.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_Jewelry.BD
{
    public class DbContextJewelry:DbContext
    {
        public DbContextJewelry()
        {
        }

        public DbContextJewelry(DbContextOptions<DbContextJewelry> options)
            : base(options)
        {


        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Master> masters { get; set; }
        public DbSet<Material> materials { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
     




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Master>(x =>
            {
                x.HasKey(x => x.IdMaster);

                x.HasMany(y => y.Orders).WithOne(y => y.master).HasForeignKey(y => y.MasterOrder);

            });



            modelBuilder.Entity<Material>(x =>
            {
                x.HasKey(x => x.IdMaterials);
                x.HasMany(y => y.product).WithOne(y => y.Material).HasForeignKey(y => y.MaterialID);


            });



            modelBuilder.Entity<Order>(x=>
            {
                x.HasKey(x => x.IdOrder);



            });



            modelBuilder.Entity<Product>(x =>
            {
                x.HasKey(x => x.IDProducts);
               x.HasMany(y => y.Orders).WithOne(y => y.product).HasForeignKey(y => y.ProductsID);


            });




            modelBuilder.Entity<Client>(x =>
            {
                x.HasKey(y => y.IdClient);
                x.HasMany(y => y.Orders).WithOne(y => y.client).HasForeignKey(y => y.ClientID);



            });

        }


    }

}

