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
    }
}
