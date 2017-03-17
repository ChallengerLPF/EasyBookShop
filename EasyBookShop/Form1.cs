﻿using EasyBookShop.com.easy.controal;
using EasyBookShop.com.easy.model;
using EasyBookShop.com.easy.view;
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
            
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            removeText(txt_uname);
        }

        private void setText(TextBox name, String text)
        {
            if (name.Text == "")
            {
                name.Text = text;
            }
            

        }

        private void removeText(TextBox name)
        {
           
            name.Text = "";
        }

        private void txt_uname_MouseLeave(object sender, EventArgs e)
        {
            setText(txt_uname, "U s e r  N a m e");
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            removeText(txt_psw);
        }

        private void txt_psw_MouseLeave(object sender, EventArgs e)
        {
            setText(txt_psw, "P a s s w o r d");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = txt_uname.Text;
            String pw = txt_psw.Text;

            Login lg = new Login();
            lg.Uname = uname;
            lg.Pw = pw;

            LoginControal lgc = new LoginControal();
            Login uid = lgc.logincheck(lg);

            if (uid.Id>0)
            {
                int id = uid.Id;
                uname = uid.Uname;
                MainWindow mwin = new MainWindow(id,uname);
                mwin.Show();
            }
            else
            {
               // MessageBox.Show("User Name or Password incorrect");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB_Settings DB = new DB_Settings();
            DB.Show();
        }
    }
}
