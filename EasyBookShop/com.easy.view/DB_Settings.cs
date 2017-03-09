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
            redtext();
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
                using (StreamWriter objWriter = new StreamWriter("dbconfig.txt")){

                    String txt = txt_host.Text + "," + txt_port.Text + "," + txt_uname.Text + "," + txt_pw.Text;

                    objWriter.Write(txt);
                    redtext();
                }

                
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void redtext(){

        try{
            using (StreamReader sr = new StreamReader("dbconfig.txt"))
            {
	        
                String line = sr.ReadToEnd();
                char spliter = ',';
                String[] data = line.Split(spliter);

                txt_host.Text = data[0];
                txt_port.Text = data[1];
                txt_uname.Text = data[2];
                txt_pw.Text = data[3];
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
        }
    }
}
