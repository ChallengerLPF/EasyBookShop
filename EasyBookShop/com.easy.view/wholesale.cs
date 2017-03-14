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

namespace EasyBookShop.com.easy.view
{
    public partial class wholesale : UserControl
    {
        List<String[]> item = new List<string[]>();
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
            ArrayList list = pc.findall();

            /*for (int i = 0; i < 4; i++)
            {
                datagrid_srch.Rows.Add(i, list);
            }*/

            foreach (Wholesale data in list)
            {
                datagrid_srch.Rows.Add(data.Dis,data.Brnd,data.Qty,data.Price);
            }

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
            
            Productcontroaler pc = new Productcontroaler();
            Wholesale data = pc.findone(itemcode);

            int qty = (int)data.Qty;
            double price = (double)data.Price;
            String p = price.ToString();
            double op = (double)data.Orprice;
            String orp = op.ToString();
            int id=data.Id;

            txt_dis.Text = (String)data.Dis;
            txt_qty.Text = qty.ToString();
            txt_selprice.Text = p;
            txt_orprice.Text = orp;
            lbl_id.Text = id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dis = txt_dis.Text;
            String qty = txt_rqty.Text;
            String uprice = txt_selprice.Text;
            String id = lbl_id.Text;

            String[] dataset={dis,qty,uprice,id};

            additem(dataset);
            calnettotal();
        }

        private void additem(String[] data)
        {
            item.Add(data);
            setTable();
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
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
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
            MessageBox.Show("test");
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
            //ClearAllText(this);
            //ClearGrid(datagrid_bill);
            //item.Clear();

            Perchuspopup pup = new Perchuspopup();
            pup.Show();
        }
    }
}
