﻿using EasyBookShop.com.easy.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBookShop
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            whole_sale sale = new whole_sale();
            sale.Show();
        }
    }
}
