using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBookShop.com.easy.controal;
using System.Collections;
using EasyBookShop.com.easy.model;
using EasyBookShop.com.easy.utility;
using MySql.Data.MySqlClient;

namespace EasyBookShop.com.easy.view
{
    public partial class wholesale : UserControl
    {
        public static List<String[]> item = new List<string[]>();
        
        MainWindow mw = new MainWindow();
        public wholesale()
        {
            InitializeComponent();
            loadtb();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datagrid_srch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadtb()
        {
           
            Productcontroaler pc = new Productcontroaler();
            MySqlDataAdapter list = pc.findall();
            DataTable dt = new DataTable();
            list.Fill(dt);
            datagrid_srch.DataSource = dt;
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_icode_KeyUp(object sender, KeyEventArgs e)
        {
            String itemcode = txt_icode.Text;
            
            Customer_validate cv=new Customer_validate();
            Productcontroaler pc = new Productcontroaler();
            Wholesale data = pc.findone(itemcode);

            int qty = (int)data.Qty;
            double price = (double)data.Price;
            String p = price.ToString();
            double op = (double)data.Orprice;
            String orp = op.ToString();
            int id=data.Id;

            if (cv.validate_text((String)data.Dis, "Item not found"))
            {
                txt_icode.BackColor = SystemColors.Control;
                txt_dis.Text = (String)data.Dis;
                txt_qty.Text = qty.ToString();
                txt_selprice.Text = p;
                txt_orprice.Text = orp;
                lbl_id.Text = id.ToString();
            }
            else
            {
                txt_icode.Clear();
                txt_icode.BackColor = Color.Red;
                txt_dis.Text = (String)data.Dis;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dis = txt_dis.Text;
            String qty = txt_rqty.Text;
            String uprice = txt_selprice.Text;
            String id = lbl_id.Text;
            String sqty = txt_qty.Text;

            String[] dataset={dis,qty,uprice,id,sqty};

            additem(dataset);
            calnettotal();
        }

        private void additem(String[] data)
        {
            Customer_validate cv = new Customer_validate();

            if (cv.Qty_validate(txt_qty.Text, txt_rqty.Text))
            {
                item.Add(data);
                setTable();
            }
            
        }

        private void setTable()
        {
            ClearGrid(datagrid_bill);
            int count = 1;
            foreach (String[] items in item)
            {
               
                
                    try
                    {
                        double total = double.Parse(items[2]) * int.Parse(items[1]);

                        datagrid_bill.Rows.Add(count, items[0], items[1], items[2], total);

                        count++;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                
            }

            calnettotal();
           
        }

        private void calnettotal()
        {
            
            double nettotal=0;
            //datagrid_bill dg = new datagrid_bill(); 

            for (int i = 0; i < datagrid_bill.RowCount; i++)
            {
                double val=Convert.ToDouble(datagrid_bill.Rows[i].Cells[4].Value);
                nettotal += val;

            }

            txt_nettotal.Text = nettotal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearGrid(datagrid_bill);
            ClearAllText(this);
            resetcustomer();
        }

        public void ClearGrid(DataGridView grid)
        {
            if (grid.RowCount > 0)
            {
                grid.Rows.Clear();
            }
        }

        void ClearAllText(Control obj)
        {
            foreach (Control c in obj.Controls)
            {
               // MessageBox.Show(c.ToString);
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void resetcustomer()
        {
            lbl_cno.Text = "Customer No : ";
            lbl_name.Text = "Customer Name : ";
            lbl_pending.Text = "Pending Payments";
            lbl_level.Text = "Customer Type";
            cus_nic.Text = "";

        }

        private void datagrid_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int rowIndex;
        private void datagrid_bill_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            
            if (!this.datagrid_bill.Rows[this.rowIndex].IsNewRow)
            {
                int row = this.rowIndex;
                this.datagrid_bill.Rows.RemoveAt(this.rowIndex);
                item.RemoveAt(row);
                setTable();

            }
        }

        private void datagrid_bill_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.datagrid_bill.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.datagrid_bill.CurrentCell = this.datagrid_bill.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.datagrid_bill, e.Location);
                contextMenuStrip1.Show(Cursor.Position);

            }
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {

            Customer_validate cv = new Customer_validate();

            Console.WriteLine(datagrid_bill.RowCount);

            if (datagrid_bill.RowCount > 1)
            {
                if (cv.customer(lbl_cno.Text))
                {
                    try
                    {

                        Perchuspopup pup = new Perchuspopup();
                        pup.Show();
                        pup.SetBill(this);
                        ClearAllText(this);
                        ClearGrid(datagrid_bill);
                        resetcustomer();
                        //item.Clear();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Customer Details Invalide");
                    resetcustomer();
                }

            }
            else
            {
                MessageBox.Show("There are no item to purches");
            }

            
            
        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            getcustomer();
            getpending();
        }

        private void getcustomer()
        {
            String nic = cus_nic.Text;

            Customer_controal cus = new Customer_controal();

            Customer cs = cus.getuser(nic);

                String gen = cs.Gender;
                MessageBox.Show("Gender "+gen);

            try{

                if (gen.Equals("male"))
                {
                    lbl_name.Text = "Mr. " + cs.Fname;
                }
                else
                {
                    lbl_name.Text = "Ms. " + cs.Fname;
                }

                String id = Convert.ToString(cs.Id);
                lbl_cno.Text = "Customer No : " + id;
                lbl_level.Text = cs.Level;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                resetcustomer();
            }
                
    
        }

        private void getpending()
        {
            int len = lbl_cno.Text.Length;
            String customer=lbl_cno.Text;
            String id = customer.Substring(13, len-13);

            Customer_controal cus = new Customer_controal();

            Customer cs = cus.getpending(id);

            lbl_pending.Text = "Pending :" + cs.Pendings;

        }

        private void txt_rqty_KeyUp(object sender, KeyEventArgs e)
        {
            Customer_validate cs = new Customer_validate();

            if (cs.Qty_validate(txt_qty.Text, txt_rqty.Text)==false)
            {
                txt_rqty.Clear();
                txt_rqty.BackColor = Color.Red;
            }
            else
            {
                txt_rqty.BackColor = SystemColors.Control;
            }
        }

        private void metroTextBox8_KeyUp(object sender, KeyEventArgs e)
        {
            if (Rbtn_bname.Checked || Rbtn_iname.Checked)
            {
                if (Rbtn_iname.Checked)
                {
                    search_by_iname();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Select Search Option");
            }
        }

        private void search_by_iname()
        {
            
            String dis = txt_search.Text;

            Productcontroaler pc = new Productcontroaler();
            MySqlDataAdapter list = pc.search_byIname(dis);
            DataTable dt = new DataTable();
            list.Fill(dt);
            datagrid_srch.DataSource=dt;

        }

        private void txt_search_Click(object sender, EventArgs e)
        {

        }
    }
}
