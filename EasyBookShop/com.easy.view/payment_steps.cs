using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBookShop.com.easy.model;
using EasyBookShop.com.easy.controal;
using MySql.Data.MySqlClient;

namespace EasyBookShop.com.easy.view
{
    public partial class payment_steps : UserControl
    {
        public payment_steps()
        {
            InitializeComponent();
        }

        private void payment_steps_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadtb(int id)
        {
            WholesalePayment_steps wps = new WholesalePayment_steps();
            wps.Invoice = id;
            lbl_inv.Text = "Invoice No : " + id.ToString();
            WhalesalePaymentStepControall wpsc = new WhalesalePaymentStepControall();

            MySqlDataAdapter da = wpsc.getsteps(wps);
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource dbs = new BindingSource();
            dbs.DataSource = dt;
            datagrid_paymentstep.DataSource = dbs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void datagrid_paymentstep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
