using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EasyBookShop.com.easy.controal;
using EasyBookShop.com.easy.model;
using EasyBookShop.com.easy.utility;

namespace EasyBookShop.com.easy.view
{
    public partial class Multiple_Items : UserControl
    {
        wholesale obj;
        String barcode;
        public Multiple_Items()
        {
            InitializeComponent();
        }

        private void txt_icode_Click(object sender, EventArgs e)
        {

        }

        private void Multiple_Items_Load(object sender, EventArgs e)
        {
            
        }

        public void loadtb(String barcode,wholesale obj)
        {
            this.obj = obj;
            this.barcode = barcode;
            Productcontroaler pc=new Productcontroaler();
            MySqlDataAdapter da = pc.findmitual(barcode);
            DataTable dt = new DataTable();
            da.Fill(dt);

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            da.Update(dt);

            this.dataGridView1.Columns[0].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            obj.setTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void setitem(String id)
        {
            Productcontroaler pc = new Productcontroaler();
            Wholesale item = pc.findoneById(id);
            txt_icode.Text = item.Code;
            txt_dis.Text = item.Dis;
            txt_qty.Text = item.Qty.ToString();
            txt_orprice.Text = item.Orprice.ToString();
            txt_selprice.Text = item.Price.ToString();
            lbl_id.Text = item.Id.ToString();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dis = txt_dis.Text;
            String qty = txt_rqty.Text;
            String uprice = txt_selprice.Text;
            String id = lbl_id.Text;
            String sqty = txt_qty.Text;

            String[] dataset = { dis, qty, uprice, id, sqty };

            additem(dataset);
            loadtb(barcode,obj);
        }

        public void additem(String[] data)
        {
            Customer_validate cv = new Customer_validate();
            
            if (cv.Qty_validate(txt_qty.Text, txt_rqty.Text))
            {
                wholesale.item.Add(data);

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["ID"].Value);

                setitem(a);

            }
        }

        private void txt_rqty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
            {
                Customer_validate cs = new Customer_validate();

                if (cs.Qty_validate(txt_qty.Text, txt_rqty.Text) == false)
                {
                    txt_rqty.Clear();
                    txt_rqty.BackColor = Color.Red;
                }
                else
                {
                    txt_rqty.BackColor = SystemColors.Control;
                }
            }
        }

        private void Show_hide_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_hide.Checked)
            {
                txt_orprice.UseSystemPasswordChar = true;
                Show_hide.Text = "Hide";
            }
            else
            {
                txt_orprice.UseSystemPasswordChar = false;
                Show_hide.Text = "Show";
            }
        }
    }
}
