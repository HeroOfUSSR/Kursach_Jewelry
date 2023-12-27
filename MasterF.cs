using Kursach_Jewelry.BD;
using Kursach_Jewelry.Models;
using Kursach_Jewelry.ModelsResponce;
using Microsoft.EntityFrameworkCore;
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
    public partial class MasterF : Form
    {
        public MasterF()
        {
            InitializeComponent();

            InidDatagrid();
        }

        private void InidDatagrid()
        {
            using (var dbContext = new DbContextJewelry(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.masters.Select(x => new MasterResponce
                {
                    IdMaster = x.IdMaster,
                    NameMaster = x.NameMaster,
                    PhoneMaster = x.PhoneMaster,
                    OrderMaster = x.OrderMaster

                }).ToList();

            }
        }

        private void addClick_Click(object sender, EventArgs e)
        {
        


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
       
        }

        private void Edit_Click(object sender, EventArgs e)
        {
    
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            textBox1.Text = dr.Cells[1].Value.ToString();
            textBox2.Text = dr.Cells[2].Value.ToString();
            textBox3.Text = dr.Cells[3].Value.ToString();

        }

        private void CleareBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void addClick_Click_1(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {

                Master master = new Master
                {
                    NameMaster = textBox1.Text,
                    PhoneMaster = textBox2.Text,
                    OrderMaster = Convert.ToInt32(textBox3.Text),

                };

                db.masters.Add(master);
                db.SaveChanges();


                InidDatagrid();


            }
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new(DataBaseHelper.Option()))
            {
                var id = (MasterResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.masters.FirstOrDefault(x => x.IdMaster == id.IdMaster);



                db.masters.Remove(editclient);
                db.SaveChanges();

            }



            InidDatagrid();
        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {

                var id = (MasterResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.masters.FirstOrDefault(x => x.IdMaster == id.IdMaster);


                editclient.NameMaster = textBox1.Text;
                editclient.PhoneMaster = textBox2.Text;
                editclient.OrderMaster = Convert.ToInt32(textBox3.Text);
                db.masters.Update(editclient);
                db.SaveChanges();



            }
            InidDatagrid();
        }

        private void CleareBtn_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
