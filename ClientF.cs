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
    public partial class ClientF : Form
    {
        public ClientF()
        {
            InitializeComponent();
            InidDatagrid();
        }

        private void InidDatagrid()
        {
            using (var dbContext = new DbContextJewelry(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Client.Select(x => new ClientResponce
                {
                    IdClient = x.IdClient,
                    NameClient = x.NameClient,
                    PhoneClient = x.PhoneClient,
                    OrderClient = x.OrderClient

                }).ToList();

            }
        }

        private void addClick_Click(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {

                Client client = new Client
                {
                    NameClient = textBox1.Text,
                    PhoneClient = textBox2.Text,
                    OrderClient = Convert.ToInt32(textBox3.Text),

                };

                db.Client.Add(client);
                db.SaveChanges();


                InidDatagrid();


            }



        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {
                var id = (ClientResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.Client.FirstOrDefault(x => x.IdClient == id.IdClient);


                editclient.NameClient = textBox1.Text;
                editclient.PhoneClient = textBox2.Text;
                editclient.OrderClient = Convert.ToInt32(textBox3.Text);
                db.Client.Remove(editclient);
                db.SaveChanges();

                InidDatagrid();

            }


        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            textBox1.Text = dr.Cells[1].Value.ToString();
            textBox2.Text = dr.Cells[2].Value.ToString();
            textBox3.Text = dr.Cells[3].Value.ToString();

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {
                var id = (ClientResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.Client.FirstOrDefault(x => x.IdClient == id.IdClient);


                editclient.NameClient = textBox1.Text;
                editclient.PhoneClient = textBox2.Text;
                editclient.OrderClient = Convert.ToInt32(textBox3.Text);
                db.Client.Update(editclient);
                db.SaveChanges();

                InidDatagrid();

            }



        }

        private void CleareBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
