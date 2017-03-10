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

            txt_dis.Text = (String)data.Dis;
            txt_qty.Text = qty.ToString();
            txt_selprice.Text = p;
            txt_orprice.Text = orp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dis = txt_dis.Text;
            String qty = txt_rqty.Text;
            String uprice = txt_selprice.Text;

            String[] dataset={dis,qty,uprice};

            setTable(dataset);
            calnettotal();
        }

        private void setTable(String[] data)
        {
            try
            {
                double total = double.Parse(data[2]) * int.Parse(data[1]);

                datagrid_bill.Rows.Add(datagrid_bill.RowCount, data[0], data[1], data[2], total);

               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
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
    }
}
