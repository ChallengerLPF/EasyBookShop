using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EasyBookShop.com.easy.view
{
    public partial class DB_Settings : MetroFramework.Forms.MetroForm
    {
        public DB_Settings()
        {
            InitializeComponent();
        }

        private void DB_Settings_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            txt_host.Text = "localhost";
            txt_port.Text = "3306";
            txt_uname.Text = "root";
            txt_pw.Text = "123,";

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            try
            {
                StreamWriter objWriter = new StreamWriter("dbconfig.txt");

                objWriter.Write(txt_host.Text);
                objWriter.Write(txt_port.Text);
                objWriter.Write(txt_uname.Text);
                objWriter.Write(txt_pw.Text);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
