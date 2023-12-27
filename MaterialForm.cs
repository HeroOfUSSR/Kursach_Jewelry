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
    public partial class MaterialForm : Form
    {
        public MaterialForm()
        {
            InitializeComponent();
            InidDatagrid();
        }

        private void InidDatagrid()
        {
            using (var dbContext = new DbContextJewelry(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.materials.Select(x => new MaterialResponce
                {
                    IdMaterials = x.IdMaterials,
                    NameMaterial = x.NameMaterial,
                    ColorMaterial = x.ColorMaterial,
                    SampleMaterial = x.SampleMaterial

                }).ToList();

            }
        }

        private void addClick_Click(object sender, EventArgs e)
        {
          
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
       
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
        
        }

        private void CleareBtn_Click(object sender, EventArgs e)
        {

        }

        private void addClick_Click_1(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {

                Material master = new Material
                {
                    NameMaterial = textBox1.Text,
                    ColorMaterial = textBox2.Text,
                    SampleMaterial = Convert.ToInt32(textBox3.Text),

                };

                db.materials.Add(master);
                db.SaveChanges();


                InidDatagrid();


            }
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {
                var id = (MaterialResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.materials.FirstOrDefault(x => x.IdMaterials == id.IdMaterials);


                editclient.NameMaterial = textBox1.Text;
                editclient.ColorMaterial = textBox2.Text;
                editclient.SampleMaterial = Convert.ToInt32(textBox3.Text);
                db.materials.Remove(editclient);
                db.SaveChanges();

                InidDatagrid();

            }
        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
            using (DbContextJewelry db = new DbContextJewelry(DataBaseHelper.Option()))
            {

                var id = (MaterialResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.materials.FirstOrDefault(x => x.IdMaterials == id.IdMaterials);


                editclient.NameMaterial = textBox1.Text;
                editclient.ColorMaterial = textBox2.Text;
                editclient.SampleMaterial = Convert.ToInt32(textBox3.Text);
                db.materials.Update(editclient);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
