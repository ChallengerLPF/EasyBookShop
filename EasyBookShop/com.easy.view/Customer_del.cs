using EasyBookShop.com.easy.controal;
using EasyBookShop.com.easy.model;
using MySql.Data.MySqlClient;
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
        private String method;
        public Customer_del(String id,String method)
        {
            this.id = id;
            this.method = method;
            InitializeComponent();
            getDetails();
            setdefault();

        }

        private void Customer_del_Load(object sender, EventArgs e)
        {
            findmethod();
            setDefault();
        }

        private void setdefault()
        {
            cmb_method.SelectedItem = method;
        }

        private void getDetails()
        {
            Customer cus = new Customer();
            
            Customer_controal cc = new Customer_controal();
            cus = cc.getcustomer(int.Parse(id));

            lbl_name.Text = cus.Fname+"  ("+cus.Level+" customer)";
            lbl_nic.Text = cus.Nic;

            Customerdetail customer = new Customerdetail();
            customer.Customer = int.Parse(id);
            Customer_delControal cdc = new Customer_delControal();
            Customerdetail del = cdc.totalpending(customer);
            decimal pending = del.Pending;

            if (pending > 0)
            {
                lbl_pending.Text ="Total Pending Rs : "+pending.ToString();
            }else{
                lbl_pending.ForeColor = Color.FromArgb(192, 192, 0);
                lbl_pending.Text = "No Pending Payments";
            }
            
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

        private void findmethod()
        {
            String item = cmb_method.SelectedItem.ToString();

            switch (item)
            {
                case "All payments":
                    loadtb("*");
                    break;

                case "Cash payments":
                    loadtb("cash");
                    break;

                case "Check payments":
                    loadtb("cheque");
                    break;

                case "Credit payments":
                    loadtb("credit");
                    break;

                default:
                    break;
            }
        }

        private void loadtb(String type)
        {
            ClearGrid();
            Customer_delControal cdc = new Customer_delControal();
            Customerdetail cd = new Customerdetail();

            cd.Customer = int.Parse(id);
            cd.Method = type;

            MySqlDataAdapter da= cdc.getAllBils(cd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource dbs = new BindingSource();
            dbs.DataSource = dt;
            
            datagrid_cusdel.DataSource = dbs;

            DataGridViewImageColumn upbut = new DataGridViewImageColumn();
            upbut.Image = Image.FromFile("../../images/refresh.png");
            upbut.HeaderText = "Update";
            datagrid_cusdel.Columns.Add(upbut);

            DataGridViewImageColumn viewbut = new DataGridViewImageColumn();
            viewbut.Image = Image.FromFile("../../images/view.png");
            viewbut.HeaderText = "View";
            datagrid_cusdel.Columns.Add(viewbut);
        }

        public void ClearGrid()
        {

            datagrid_cusdel.Columns.Clear();
            //datagv_cus.Update();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                String blno = datagrid_cusdel.Rows[e.RowIndex].Cells[0].Value.ToString();
                String total = datagrid_cusdel.Rows[e.RowIndex].Cells[2].Value.ToString();
                String pending = datagrid_cusdel.Rows[e.RowIndex].Cells[6].Value.ToString();

                txt_blno.Text = blno;
                txt_billtotal.Text = total;
                txt_pending.Text = pending;

            }
            else if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                               
            }

        }

        private void cmb_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            findmethod();
        }

        private void setDefault()
        {
            txt_payment.Enabled = false;
            txt_balance.Enabled = false;
            txt_chno.Enabled = false;
            txt_chvalue.Enabled = false;
            txt_expmt.Enabled = false;
        }

        private void metroRadioButton1_Click(object sender, EventArgs e)
        {
            txt_payment.Enabled = true;
            txt_chno.Enabled = false;
            txt_chvalue.Enabled = false;
            txt_expmt.Enabled = false;
        }

        private void metroRadioButton2_Click(object sender, EventArgs e)
        {
            txt_payment.Enabled = false;
            txt_chno.Enabled = true;
            txt_chvalue.Enabled = true;
            txt_expmt.Enabled = true;

            Customer_delControal cdc = new Customer_delControal();
            Customerdetail chid = cdc.getCheckid();
            int chno=chid.Checkid+1;
            txt_chno.Text = chno.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtn_cash.Checked)
            {
                add_pamentStep();
            }
        }

        private void add_pamentStep()
        {
            decimal pending = decimal.Parse(txt_pending.Text);
            decimal payment = decimal.Parse(txt_payment.Text);
            

            Customerdetail cus = new Customerdetail();
            Customer_delControal cdc = new Customer_delControal();

            if (payment >= pending)
            {
                try
                {
                    cus.Method = "cash";
                    cus.Patialpayment = pending;
                    cus.Invoice = int.Parse(txt_blno.Text);
                    cdc.addpayment_step(cus);
                    cdc.updateinvoice(cus);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                

            }
            else
            {
                cus.Patialpayment = payment;
                cus.Invoice = int.Parse(txt_blno.Text);
                cdc.addpayment_step(cus);
                
            }
        }
    }
}
