﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBookShop.models;

namespace EasyBookShop
{
    public partial class Retail_Invoice : MetroFramework.Forms.MetroForm
    {
        public Retail_Invoice()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            gridItemList.Rows.Add(new item());
        }
    }
}
