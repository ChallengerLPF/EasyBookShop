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
using EasyBookShop.com.easy.utility;
using EasyBookShop.com.easy.model;

namespace EasyBookShop.com.easy.view
{
    public partial class Cheque_Payment : UserControl
    {
        Spliter sp = new Spliter();
        int customer;
        String cuslevel;
        List<String[]> items = new List<string[]>();

        public Cheque_Payment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChequePayment cp = new ChequePayment();
            cp.Bank_name = cmb_bank.SelectedItem.ToString();
            ChequePaymentControal cpc=new ChequePaymentControal();
            ChequePayment cheque= cpc.getbankid(cp);
            int bid = cheque.Bankid;

            lbl_bid.Text = bid.ToString();
        }

        private void loadBank()
        {
            ChequePaymentControal cpc=new ChequePaymentControal();
            List<String> bank_list = cpc.GetAllBank();

            foreach (String bankname in bank_list)
            {
                cmb_bank.Items.Add(bankname);
            }
        }

        public void SetBill(String[] pp)
        {
            
            txt_bno.Text = pp[0];

            txt_nettotal.Text = pp[2];

            /*assining values*/
            this.items = wholesale.item;

            customer = int.Parse(pp[1]);
            cuslevel = pp[3];

            txt_cusno.Text = customer.ToString();


        }

        private void Cheque_Payment_Load(object sender, EventArgs e)
        {
            loadBank();
        }

        public void insert_invoice(String method)
        {

            /*get user*/
            String user = MainWindow.user;
            char[] chaeset = { '[', ']' };
            String[] rtxt = sp.Split_text(user, chaeset);


            /*set model object...*/
            ChequePayment pup= new ChequePayment();
            pup.Total = decimal.Parse(txt_nettotal.Text);
            pup.Customer = customer;
            pup.Customer_level = cuslevel;
            pup.Method = method;
            pup.Cashier = int.Parse(rtxt[1]);

            Customer_delControal cdc = new Customer_delControal();
            Customerdetail chid = cdc.getCheckid();
            int chno = chid.Checkid;

            
            /*set controller object...*/
            ChequePaymentControal cpc = new ChequePaymentControal();
            cpc.save_invoice(pup);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            setsequence();
            this.Dispose();

            
        }

        private void setsequence()
        {
            decimal total = decimal.Parse(txt_nettotal.Text);
            decimal checkvalue = decimal.Parse(txt_chamount.Text);
            

            if (!txt_expmt.Equals(""))
            {

                if (total <= checkvalue)
                {
                    insert_invoice("cash");
                    add_invoice_items();
                    insertcheque();
                    AddWIC();
                    insert_paymentstep(total, "cheque");
                    updateitem();
                    
                }
                else
                {
                    insert_invoice("credit");
                    add_invoice_items();
                    insertcheque();
                    AddWIC();
                    insert_paymentstep(checkvalue, "cheque");
                    updateitem();
                }
            }
            else
            {
                decimal extra = decimal.Parse(txt_expmt.Text);
                decimal allamount = checkvalue + extra;

                if (allamount >= total)
                {
                    insert_invoice("cash");
                    add_invoice_items();
                    insertcheque();
                    AddWIC();
                    insert_paymentstep(checkvalue, "cheque");
                    insert_paymentstep(checkvalue, "cash");
                    updateitem();
                }
                else
                {
                    insert_invoice("credit");
                    add_invoice_items();
                    insertcheque();
                    AddWIC();
                    insert_paymentstep(checkvalue, "cheque");
                    insert_paymentstep(checkvalue, "cash");
                    updateitem();
                }
            }

           

        }

        private void insertcheque()
        {
            ChequePayment cp = new ChequePayment();
            cp.Bankid = int.Parse(lbl_bid.Text);
            cp.Chamount = decimal.Parse(txt_chamount.Text);
            cp.Status = "not_cashed";
            cp.Chnumber = txt_chno.Text;

            ChequePaymentControal cpc = new ChequePaymentControal();
            cpc.addcheque(cp);
        }

        private void insert_paymentstep(decimal partialpayment,String method)
        {
            ChequePayment cp = new ChequePayment();

            if (method.Equals("cheque"))
            {
                ChequePaymentControal cpc=new ChequePaymentControal();
                ChequePayment cheque=cpc.getCheckid();
                cp.Blno = int.Parse(txt_bno.Text);
                cp.Ppamount = partialpayment;
                cp.Method = method;
                cp.Chid = cheque.Chid;

                cpc.addpaymentstep(cp);
            }
            else
            {
                ChequePaymentControal cpc = new ChequePaymentControal();
                cp.Blno = int.Parse(txt_bno.Text);
                cp.Ppamount = partialpayment;
                cp.Method = method;
                cpc.addpaymentstep(cp);
            }
            
            
        }


        private void add_invoice_items()
        {
            ChequePaymentControal cpc = new ChequePaymentControal();
            ChequePayment cp = new ChequePayment();


            foreach (String[] item in items)
            {

                cp.Blno = int.Parse(txt_bno.Text);
                cp.Item1 = int.Parse(item[3]);
                cp.Qty = int.Parse(item[1]);
                cp.Uprice = decimal.Parse(item[2]);


                cpc.insert_items(cp);

            }
        }

        private void updateitem()
        {
            ChequePaymentControal cpc = new ChequePaymentControal();
            ChequePayment cp = new ChequePayment();

            foreach (String[] item in items)
            {
                cp.Item1= int.Parse(item[3]);
                cp.Qty = int.Parse(item[4]);
                cp.Rqty = int.Parse(item[1]);

                cpc.updateitem(cp);
            }
        }


        private void AddWIC()
        {
            ChequePayment cp = new ChequePayment();

            ChequePaymentControal cpc = new ChequePaymentControal();
            ChequePayment cheque = cpc.getCheckid();
            int chid=cheque.Chid;
            MessageBox.Show(chid.ToString());
            cp.Blno = int.Parse(txt_bno.Text);
            cp.Chid = chid;


            cpc.AddWIC(cp);
        }
    }
}
