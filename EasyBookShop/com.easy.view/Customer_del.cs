using EasyBookShop.com.easy.controal;
using EasyBookShop.com.easy.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBookShop.com.easy.view
{
    public partial class Customer_del : MetroFramework.Forms.MetroForm
    {

        private String id;
        public Customer_del(String id)
        {
            this.id = id;
            InitializeComponent();
            getDetails();

        }

        private void Customer_del_Load(object sender, EventArgs e)
        {

        }

        private void getDetails()
        {
            Customer cus = new Customer();
            
            Customer_controal cc = new Customer_controal();
            cus = cc.getcustomer(int.Parse(id));

            lbl_name.Text = cus.Fname+"  ("+cus.Level+" customer)";
            lbl_nic.Text = cus.Nic;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
