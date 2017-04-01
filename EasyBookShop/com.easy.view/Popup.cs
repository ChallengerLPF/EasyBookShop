﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBookShop.com.easy.controal;
using EasyBookShop.com.easy.model;
using EasyBookShop.com.easy.utility;

namespace EasyBookShop.com.easy.view
{
    public partial class Popup : UserControl
    {

        Spliter sp = new Spliter();
        int customer;
        String cuslevel;
        List<String[]> items = new List<string[]>();

        public Popup()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetBill(wholesale obj)
        {
            Perchuspopup_controaler ppc = new Perchuspopup_controaler();
            Puschespopup pp = ppc.setbilno();

            int id = pp.Id;
            txt_bno.Text = id.ToString();

            txt_nettotal.Text = obj.txt_nettotal.Text;

            /*assining values*/
            this.items = wholesale.item;
            String cus = obj.lbl_cno.Text;
            customer = int.Parse(cus.Substring(13, (cus.Length - 13)));
            cuslevel = obj.lbl_level.Text;

            txt_cusno.Text = customer.ToString();


        }

        public void insert_invoice(String method)
        {

            /*get user*/
            String user = MainWindow.user;
            char[] chaeset = { '[', ']' };
            String[] rtxt = sp.Split_text(user, chaeset);


            /*set model object...*/
            Puschespopup pup = new Puschespopup();
            pup.Total = decimal.Parse(txt_nettotal.Text);
            pup.Cus = customer;
            pup.Cuslevel = cuslevel;
            pup.Method = method;
            pup.Cashire = int.Parse(rtxt[1]);

            /*set controller object...*/
            Perchuspopup_controaler ppc = new Perchuspopup_controaler();
            ppc.save_invoice(pup);



        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            try
            {
                insert_invoice("cash");
                add_invoice_items();
                insertpaymentsteps("cash");
                updateitem();
                ClearList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearList()
        {

            items.Clear();
            wholesale.item.Clear();
        }

        private void txt_pmnt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                decimal total = decimal.Parse(txt_nettotal.Text);
                decimal payment = decimal.Parse(txt_pmnt.Text);

                decimal balance = payment - total;

                txt_balance.Text = balance.ToString();
            }
            catch
            {
                MessageBox.Show("Invalide Number");
                txt_pmnt.Text = "";
            }
        }

        private void add_invoice_items()
        {
            Perchuspopup_controaler ppc = new Perchuspopup_controaler();
            Puschespopup pup = new Puschespopup();


            foreach (String[] item in items)
            {

                pup.Id = int.Parse(txt_bno.Text);
                pup.Item = int.Parse(item[3]);
                pup.Qty = int.Parse(item[1]);
                pup.Uprice = decimal.Parse(item[2]);


                ppc.insert_items(pup);

            }
        }

        private void updateitem()
        {
            Perchuspopup_controaler ppc = new Perchuspopup_controaler();
            Item it = new Item();

            foreach (String[] item in items)
            {

                it.Id = int.Parse(item[3]);
                it.Qty = int.Parse(item[1]);
                it.Rqty = int.Parse(item[4]);

                ppc.update_items(it);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                insert_invoice("credit");
                add_invoice_items();
                insertpaymentsteps("credit");
                updateitem();
                ClearList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertpaymentsteps(String method)
        {

            switch (method)
            {

                case "credit":

                    if (!txt_pmnt.Text.Equals(""))
                    {
                        try
                        {
                            decimal pay = decimal.Parse(txt_pmnt.Text);
                            Invoice_payment_steps ips = new Invoice_payment_steps();
                            ips.Invoice = int.Parse(txt_bno.Text);
                            ips.Patial_payment1 = pay;


                            Invoice_payment_steps_controal ipsc = new Invoice_payment_steps_controal();
                            ipsc.insert_step(ips);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Invalied number");
                        }
                    }
                    else
                    {
                        decimal pay = 0;
                        Invoice_payment_steps ips = new Invoice_payment_steps();
                        ips.Invoice = int.Parse(txt_bno.Text);
                        ips.Patial_payment1 = pay;


                        Invoice_payment_steps_controal ipsc = new Invoice_payment_steps_controal();
                        ipsc.insert_step(ips);
                    }

                    break;

                case "cash":

                    try
                    {
                        decimal pay = decimal.Parse(txt_nettotal.Text);
                        Invoice_payment_steps ips = new Invoice_payment_steps();
                        ips.Invoice = int.Parse(txt_bno.Text);
                        ips.Patial_payment1 = pay;
                        ips.Method = "cash";

                        Invoice_payment_steps_controal ipsc = new Invoice_payment_steps_controal();
                        ipsc.insert_step(ips);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Invalied number");
                    }

                    break;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            wholesale.item.Clear();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cheque_Payment chp = new Cheque_Payment();
            String[] details = new String[4];
            details[0] = txt_bno.Text;
            details[1] = txt_cusno.Text;
            details[2] = txt_nettotal.Text;
            //details[3] = customer.ToString();
            details[3] = cuslevel;

            chp.SetBill(details);
            Parent.Controls.Add(chp);
            chp.Location = new Point(200, 200);
            chp.BringToFront();
            //this.Dispose();
        }


    }
}