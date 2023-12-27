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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
      
        }

        private void Productbtn_Click(object sender, EventArgs e)
        {
      
        }



        private void OrderBtn_Click_1(object sender, EventArgs e)
        {
       
        }

        private void ClientButton_Click_1(object sender, EventArgs e)
        {
            ClientF clientF = new ClientF();
            clientF.Show();
        }

        private void ClientBtn_Click_1(object sender, EventArgs e)
        {
            MaterialForm materialForm = new MaterialForm();
            materialForm.Show();
        }

        private void Productbtn_Click_1(object sender, EventArgs e)
        {
            ProductFormcs productsForm = new ProductFormcs();
            productsForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MasterF masterF = new MasterF();
            masterF.Show();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            OrderForms ordersForms = new OrderForms();
            ordersForms.Show();
        }
    }
}
