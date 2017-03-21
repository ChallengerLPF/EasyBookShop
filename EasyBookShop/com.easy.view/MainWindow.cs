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
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        private int uid;
        String uname;
        public static String user;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            wholesale sale = new wholesale();
            Main_Panel.Controls.Clear();
            Main_Panel.Controls.Add(sale);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer_view cv = new Customer_view();
            Main_Panel.Controls.Clear();
            Main_Panel.Controls.Add(cv);
        }

        public void set_user(int uid, String uname)
        {
            this.uid = uid;
            this.uname = uname;
            lbl_user.Text = uname + " [" + uid.ToString() + "]";
            user = uname + " [" + uid.ToString() + "]";
        }
    }
}
