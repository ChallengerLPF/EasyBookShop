using EasyBookShop.com.easy.controal;
using EasyBookShop.com.easy.model;
using EasyBookShop.com.easy.utility;
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
    public partial class Perchuspopup : MetroFramework.Forms.MetroForm
    {
        Spliter sp = new Spliter();
        int customer;

        public Perchuspopup()
        {
            InitializeComponent();
            SetBillNo();
        }

        public void getdata(String[] data, String total)
        {

        }

        private void Perchuspopup_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void SetBillNo()
        {
            Perchuspopup_controaler ppc = new Perchuspopup_controaler();
            Puschespopup pp=ppc.setbilno();
            
            int id=pp.Id;
            
            txt_bno.Text = id.ToString();
        }

        public void insert_invoice(wholesale obj)
        {

            /*get user*/
            String user = MainWindow.user;
            char[] chaeset = { '[', ']' };
            String[] rtxt = sp.Split_text(user,chaeset);

            /*set model object...*/
            Puschespopup pup = new Puschespopup();
            pup.Total = Convert.ToDecimal(obj.txt_nettotal.Text);
            pup.Cus = int.Parse(obj.lbl_cno.Text);
            pup.Cashire=int.Parse(rtxt[1]);
            pup.Cuslevel = obj.lbl_level.Text;
            pup.Method="cash";

            /*set controller object...*/
            Perchuspopup_controaler ppc = new Perchuspopup_controaler();
            ppc.save_invoice(pup);



        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            
        }
    }
}
