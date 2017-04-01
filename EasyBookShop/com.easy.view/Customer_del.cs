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

        private void customize_datagrid()
        {

            datagrid_cusdel.Columns[0].Width = 100;
            datagrid_cusdel.Columns[1].Width = 200;
            datagrid_cusdel.Columns[2].Width = 100;
            datagrid_cusdel.Columns[3].Width = 100;
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

            customize_datagrid();
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
                String total = datagrid_cusdel.Rows[e.RowIndex].Cells[3].Value.ToString();
                String pending = datagrid_cusdel.Rows[e.RowIndex].Cells[6].Value.ToString();

                txt_blno.Text = blno;
                txt_billtotal.Text = total;
                txt_pending.Text = pending;

            }
            else if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                payment_steps ps = new payment_steps();
                String blno = datagrid_cusdel.Rows[e.RowIndex].Cells[0].Value.ToString();
                ps.loadtb(int.Parse(blno));
                

                this.Controls.Add(ps);
                ps.BringToFront();
                ps.Location = new Point(200, 200);
                
            }

        }

        private void cmb_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            findmethod();
        }

        private void setDefault()
        {
            txt_chno.Enabled = false;
            txt_chvalue.Enabled = false;
            txt_expmt.Enabled = false;
            cmb_bank.Enabled = false;
        }

        private void metroRadioButton1_Click(object sender, EventArgs e)
        {
            txt_payment.Enabled = true;
            txt_chno.Enabled = false;
            txt_chvalue.Enabled = false;
            txt_expmt.Enabled = false;
            cmb_bank.Enabled = false;
        }

        private void metroRadioButton2_Click(object sender, EventArgs e)
        {
            txt_payment.Enabled = false;
            txt_chno.Enabled = true;
            txt_chvalue.Enabled = true;
            txt_expmt.Enabled = true;
            cmb_bank.Enabled = true;

            Customer_delControal cdc = new Customer_delControal();
            Customerdetail chid = cdc.getCheckid();
            int chno=chid.Checkid+1;
            MessageBox.Show(chno.ToString());
            lbl_chid.Text = chno.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtn_cash.Checked)
            {
                add_pamentStep();
                findmethod();
            }
            else if (rbtn_checque.Checked)
            {
                add_paymentstepChecque();
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
                    cus.Ppmethod = "cash";
                    cus.Patialpayment = pending;
                    cus.Invoice = int.Parse(txt_blno.Text);
                    cus.Method = "cash";
                    cdc.addpayment_step(cus);
                    updateinvoicestatus();
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                

            }
            else
            {
                cus.Ppmethod = "cash";
                cus.Patialpayment = payment;
                cus.Invoice = int.Parse(txt_blno.Text);
                cdc.addpayment_step(cus);
                
            }
        }

        private void add_paymentstepChecque()
        {
            decimal pending = decimal.Parse(txt_pending.Text);
            decimal chvalue = decimal.Parse(txt_chvalue.Text);

            Customerdetail cus = new Customerdetail();
            Customer_delControal cdc = new Customer_delControal();

            if (!txt_expmt.Text.Equals(""))
            {
                decimal expmt = decimal.Parse(txt_expmt.Text);

                if ((chvalue + expmt) >= pending)
                {
                    addcheck();
                    insertchecque();
                    addcashpayment();
                    updateinvoicestatus();
                    findmethod();
                }
                else
                {
                    addcheck();
                    insertchecque();
                    addcashpayment();
                    findmethod();
                }

            }
            else
            {
                if (chvalue >= pending)
                {
                    addcheck();
                    insertchecque();
                    updateinvoicestatus();
                    findmethod();
                }
                else
                {
                    addcheck();
                    insertchecque();
                    findmethod();
                }
            }
                 
        }

        private void insertchecque()
        {
            
            Customerdetail cus = new Customerdetail();
            Customer_delControal cdc = new Customer_delControal();

            cus.Patialpayment = decimal.Parse(txt_chvalue.Text);
            cus.Invoice = int.Parse(txt_blno.Text);
            cus.Ppmethod = "cheque";
            cus.Checkid = int.Parse(lbl_chid.Text);

            cdc.addpayment_step(cus);

        }

        private void addcashpayment()
        {
            
            Customerdetail cus = new Customerdetail();
            Customer_delControal cdc = new Customer_delControal();

            decimal pending = decimal.Parse(txt_pending.Text);
            decimal chvalue = decimal.Parse(txt_chvalue.Text);
            decimal paying = pending - chvalue;

            cus.Patialpayment = paying;
            cus.Invoice = int.Parse(txt_blno.Text);
            cus.Ppmethod = "cash";

            cdc.addpayment_step(cus);
        }

        private void addcheck()
        {
            
            Customerdetail cus = new Customerdetail();
            Customer_delControal cdc = new Customer_delControal();

            cus.Chno = txt_chno.Text;
            cus.Patialpayment = decimal.Parse(txt_chvalue.Text);
            cus.Chstatus = "not_cashed";

            cdc.addcheque(cus);

        }

        private void updateinvoicestatus()
        {
            Customerdetail cus = new Customerdetail();
            Customer_delControal cdc = new Customer_delControal();

            cus.Invoice = int.Parse(txt_blno.Text);
            cus.Method = "cash";

            cdc.updateinvoice(cus);

        }
    }
}
