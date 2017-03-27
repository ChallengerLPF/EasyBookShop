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
using EasyBookShop.Properties;
using System.IO;

namespace EasyBookShop.com.easy.view
{
    public partial class Customer_view : UserControl
    {
        public Customer_view()
        {
            InitializeComponent();
            setDefault();
            //findtalemode();
            customize_datagrid();
        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txt_dis_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();

            cus.Fname = txt_cname.Text;
            cus.Nic = txt_cnic.Text;
            cus.Gender = cmb_cgen.SelectedItem.ToString();
            cus.Level = cmb_clevel.SelectedItem.ToString();
            cus.Phone_no = txt_cmbo.Text;

            Customer_controal cc = new Customer_controal();
            cc.addcustomer(cus);
            findtalemode();
            customize_datagrid();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Customer_view_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2;i++ )
                findtalemode();
        }

        private void customize_datagrid()
        {
            
            datagv_cus.Columns[0].Width = 40;
            datagv_cus.Columns[1].Width = 300;
            datagv_cus.Columns[2].Width = 100;
            datagv_cus.Columns[3].Width = 100;
        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void setDefault()
        {
            //int x = cmb_boxType.Item
            cmb_fclevel.SelectedItem = "All Customers";

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Customer_controal cc = new Customer_controal();
                Customer cus = cc.getuser(txt_cunic.Text);

                String name = cus.Fname;
                String gen = cus.Gender;
                String level = cus.Level;
                String tp = cus.Phone_no;
                int id = cus.Id;


                txt_cuname.Text = name;
                txt_cuphone.Text = tp;
                cmb_cugen.SelectedItem = gen;
                cmb_culevel.SelectedItem = level;
                lbl_id.Text = id.ToString();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer_controal cc = new Customer_controal();
            Customer cus = new Customer();

            cus.Id = int.Parse(lbl_id.Text);
            cus.Nic = txt_cunic.Text;
            cus.Fname = txt_cuname.Text;
            cus.Gender = cmb_cugen.SelectedItem.ToString();
            cus.Level = cmb_culevel.SelectedItem.ToString();
            cus.Phone_no = txt_cuphone.Text;

            cc.Customer_update(cus);
            findtalemode();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadtb(String type)
        {
            ClearGrid();
            Customer_controal cc = new Customer_controal();
            MySqlDataAdapter list = cc.findall(type);
            DataTable dt = new DataTable();
            list.Fill(dt);
            BindingSource dbs = new BindingSource();
            dbs.DataSource = dt;
            datagv_cus.DataSource = dbs;

            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            delbut.Image = Image.FromFile("../../images/delete.png");
            delbut.HeaderText = "Delete";
            datagv_cus.Columns.Add(delbut);
            

            DataGridViewImageColumn upbut = new DataGridViewImageColumn();
            upbut.Image = Image.FromFile("../../images/refresh.png");
            upbut.HeaderText = "Update";
            datagv_cus.Columns.Add(upbut);

            DataGridViewImageColumn viewbut = new DataGridViewImageColumn();
            viewbut.Image = Image.FromFile("../../images/view.png");
            viewbut.HeaderText = "View";
            datagv_cus.Columns.Add(viewbut);

            customize_datagrid();
            
        }


        public void ClearGrid()
        {

            datagv_cus.Columns.Clear();
            datagv_cus.Update();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void datagv_cus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            
            if (e.ColumnIndex == 6 && e.RowIndex >= 0) //delete icon button is clicked
            {
                int id = int.Parse(datagv_cus.Rows[e.RowIndex].Cells[0].Value.ToString());
                
                DialogResult result = MessageBox.Show("Do you want to delete this record?", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    Customer_controal cc = new Customer_controal();
                    cc.delete_customer(id);

                    findtalemode();
                    
                }
            }
            else if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                String id = datagv_cus.Rows[e.RowIndex].Cells[0].Value.ToString();
                String name = datagv_cus.Rows[e.RowIndex].Cells[1].Value.ToString();
                String nic = datagv_cus.Rows[e.RowIndex].Cells[2].Value.ToString();
                String tp = datagv_cus.Rows[e.RowIndex].Cells[3].Value.ToString(); 
                String gen = datagv_cus.Rows[e.RowIndex].Cells[4].Value.ToString();
                String level = datagv_cus.Rows[e.RowIndex].Cells[5].Value.ToString();

                

                txt_cunic.Text = nic;
                txt_cuname.Text = name;
                txt_cuphone.Text = tp;


                cmb_cugen.SelectedItem = gen;
                cmb_culevel.SelectedItem = level;
                lbl_id.Text = id;

            }
            else if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                
                String id = datagv_cus.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(id);
                Customer_del cd = new Customer_del(id, "All payments");
                cd.Show();
            }
        }

        private void cmb_fclevel_SelectedIndexChanged(object sender, EventArgs e)
        {

            findtalemode();
   
        }

        private void findtalemode()
        {
            String item = cmb_fclevel.SelectedItem.ToString();

            switch (item)
            {
                case "All Customers":
                    loadtb("*");
                    break;

                case "Retail Customers":
                    loadtb("Retail");
                    break;

                case "Wholesale Customers":
                    loadtb("Wholesale");
                    break;

                case "Special Customers":
                    loadtb("Special");
                    break;

                default:
                    break;
            }
        }

        private void txt_cname_Click(object sender, EventArgs e)
        {

        }
    }
}
