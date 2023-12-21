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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursach_Jewelry
{
    public partial class OrderForms : Form
    {
        public OrderForms()
        {
            InitializeComponent();
            InidDatagrid();
        }

        private void InidDatagrid()
        {
            using (var dbContext = new DbContextJewelry(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.orders.Select(x => new OrderResponce
                {
                    IdOrder = x.IdOrder,
                    ClientID = x.ClientID,
                    DateOrder = x.DateOrder,
                    CountOrder = x.CountOrder,
                    MasterOrder = x.MasterOrder,
                    OrderCost = x.OrderCost,
                    ProductsID = x.ProductsID

                }).ToList();

            }
        }

        private void addClick_Click(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {

                Order order = new Order
                {
                    ClientID = Convert.ToInt32(textBox1.Text),
                    DateOrder = Convert.ToDateTime(textBox2.Text),
                    CountOrder = Convert.ToInt32(textBox3.Text),
                    MasterOrder = Convert.ToInt32(textBox4.Text),
                    OrderCost = Convert.ToInt32(textBox5.Text),
                    ProductsID = Convert.ToInt32(textBox6.Text),

                };

                db.orders.Add(order);
                db.SaveChanges();


                InidDatagrid();


            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            textBox1.Text = dr.Cells[2].Value.ToString();
            textBox2.Text = dr.Cells[3].Value.ToString();
            textBox3.Text = dr.Cells[4].Value.ToString();
            textBox4.Text = dr.Cells[5].Value.ToString();
            textBox5.Text = dr.Cells[6].Value.ToString();
            textBox6.Text = dr.Cells[7].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new(DataBaseHelper.Option()))
            {
                var id = (OrderResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.orders.FirstOrDefault(x => x.IdOrder == id.IdOrder);



                db.orders.Remove(editclient);
                db.SaveChanges();

            }



            InidDatagrid();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {

                var id = (OrderResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.orders.FirstOrDefault(x => x.IdOrder == id.IdOrder);


                editclient.ClientID = Convert.ToInt32(textBox1.Text);
                editclient.DateOrder = Convert.ToDateTime(textBox2.Text);
                editclient.CountOrder = Convert.ToInt32(textBox3.Text);
                editclient.MasterOrder = Convert.ToInt32(textBox4.Text);
                editclient.OrderCost = Convert.ToInt32(textBox5.Text);
                editclient.ProductsID = Convert.ToInt32(textBox6.Text);
                db.orders.Update(editclient);
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
            textBox6.Clear();
        }
    }
}
