using Kursach_Jewelry.BD;
using Kursach_Jewelry.Models;
using Kursach_Jewelry.ModelsResponce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_Jewelry
{
    public partial class ProductFormcs : Form
    {
        public ProductFormcs()
        {
            InitializeComponent();
            InidDatagrid();
        }

        private void InidDatagrid()
        {
            using (var dbContext = new DbContextJewelry(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.products.Select(x => new ProductResponce
                {
                    IDProducts = x.IDProducts,
                    NameProduct = x.NameProduct,
                    PriceProduct = x.PriceProduct,
                    TypeProduct = x.TypeProduct,
                    CountProduct = x.CountProduct,
                    MaterialID = x.MaterialID


                }).ToList();

            }
        }

        private void addClick_Click(object sender, EventArgs e)
        {

            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {

                Product product = new Product
                {
                    NameProduct = textBox1.Text,
                    PriceProduct = Convert.ToInt32(textBox2.Text),
                    TypeProduct = textBox3.Text,
                    CountProduct = Convert.ToInt32(textBox4.Text),
                    MaterialID = Convert.ToInt32(textBox5.Text)

                };

                db.products.Add(product);
                db.SaveChanges();


                InidDatagrid();


            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {
                var id = (ProductResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.products.FirstOrDefault(x => x.IDProducts == id.IDProducts);

                db.products.Remove(editclient);

                db.SaveChanges();


            }
            InidDatagrid();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            textBox1.Text = dr.Cells[1].Value.ToString();
            textBox2.Text = dr.Cells[2].Value.ToString();
            textBox3.Text = dr.Cells[3].Value.ToString();
            textBox4.Text = dr.Cells[4].Value.ToString();
            textBox5.Text = dr.Cells[5].Value.ToString();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {
                var id = (ProductResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.products.FirstOrDefault(x => x.IDProducts == id.IDProducts);


                editclient.NameProduct = textBox1.Text;
                editclient.PriceProduct = Convert.ToInt32(textBox2.Text);
                editclient.TypeProduct = textBox3.Text;
                editclient.CountProduct = Convert.ToInt32(textBox4.Text);
                editclient.MaterialID = Convert.ToInt32(textBox5.Text);
                db.products.Update(editclient);
                db.SaveChanges();



            }
            InidDatagrid();
        }

        private void CleareBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {

                var users = db.products.OrderByDescending(u => u.PriceProduct).ToList();
                dataGridView1.DataSource = users;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {

                var users = db.products.OrderBy(m => m.PriceProduct).ToList();
                dataGridView1.DataSource = users;


            }

        }
    }
}
