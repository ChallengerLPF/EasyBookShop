using EasyBookShop.com.easy.model;
using EasyBookShop.com.easy.utility;
using EasyBookShop.com.easy.view;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBookShop.com.easy.controal
{
    class Customer_delControal
    {
        public MySqlDataAdapter getAllBils(Customerdetail cus)
        {
            int customer = cus.Customer;
            DBconnection db = new DBconnection();
            String method = cus.Method;

            if (method.Equals("*"))
            {

                try
                {
                    String sql = "SELECT wholesale_invoices.id as Invoice,users.username as Cashier,wholesale_invoices.date as Date,total as Total,wholesale_invoices.method as Method,sum(wholesale_invoice_payment_steps.paid_partial_amount) as paied," +
                    "wholesale_invoices.total-sum(wholesale_invoice_payment_steps.paid_partial_amount) as Pending " +
                    "FROM users inner join wholesale_invoices inner join wholesale_invoice_payment_steps on users.id=wholesale_invoices.cashier and wholesale_invoices.id=wholesale_invoice_payment_steps.invoice" +
                    " where wholesale_invoices.customer=@cno group by wholesale_invoices.id";

                    db.init();
                    MySqlConnection con = db.getConnection();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@cno", customer);
                    cmd.Prepare();

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    return sda;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            else
            {
                try
                {
                    String sql = "SELECT wholesale_invoices.id as Invoice,users.username as Cashier,wholesale_invoices.date as Date,total as Total,wholesale_invoices.method as Method,sum(wholesale_invoice_payment_steps.paid_partial_amount) as paied," +
                    "wholesale_invoices.total-sum(wholesale_invoice_payment_steps.paid_partial_amount) as Pending " +
                    "FROM users inner join wholesale_invoices inner join wholesale_invoice_payment_steps on users.id=wholesale_invoices.cashier and wholesale_invoices.id=wholesale_invoice_payment_steps.invoice" +
                    " where wholesale_invoices.customer=@cno and wholesale_invoices.method=@method group by wholesale_invoices.id";

                    db.init();
                    MySqlConnection con = db.getConnection();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@cno", customer);
                    cmd.Parameters.AddWithValue("@method", method);
                    cmd.Prepare();

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    return sda;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            return null;
        }


        public Customerdetail getCheckid()
        {
            Customerdetail cus = new Customerdetail();
            String sql = "select max(id) as last from cheques ";

            try
            {
                DBconnection db = new DBconnection();
                db.init();
                MySqlConnection con= db.getConnection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int chid = reader.GetInt16(0);
                    cus.Checkid = chid;
                    
                }
                
            }
            catch (Exception e)
            {
                
                cus.Checkid = 0;
            }

            return cus;
        }

        public void addpayment_step(Customerdetail pamt)
        {
            decimal pmt = pamt.Patialpayment;
            int invoice = pamt.Invoice;
            String ppmethod = pamt.Ppmethod;
            MessageBox.Show(ppmethod);

            if (ppmethod.Equals("cash"))
            {
               
                String sql = "insert into wholesale_invoice_payment_steps(invoice, paid_partial_amount,date,method) values(@invoice,@ppamount,now(),@method)";

                
                    DBconnection db = new DBconnection();
                    db.init();
                    MySqlConnection con = db.getConnection();
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@invoice", invoice);
                    cmd.Parameters.AddWithValue("@ppamount", pmt);
                    cmd.Parameters.AddWithValue("@method", "cash");
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                
            }
            else if (ppmethod.Equals("cheque"))
            {
                
                int chid = pamt.Checkid;
                String sql = "insert into wholesale_invoice_payment_steps(invoice, paid_partial_amount, date,method,cheque) values (@invoice,@ppamount,now(),@method,@cheque)";

                try
                {
                    DBconnection db = new DBconnection();
                    db.init();
                    MySqlConnection con = db.getConnection();
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@invoice", invoice);
                    cmd.Parameters.AddWithValue("@ppamount", pmt);
                    MessageBox.Show(ppmethod);
                    cmd.Parameters.AddWithValue("@method", ppmethod);
                    cmd.Parameters.AddWithValue("@cheque", chid);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(sql);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }

            
            

        }

        public void updateinvoice(Customerdetail pamt)
        {
            String method = pamt.Method;
            int invoice = pamt.Invoice;

            String sql = "update wholesale_invoices set method=@method where id=@id";

            try
            {
                DBconnection db = new DBconnection();
                db.init();
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@method", method);
                cmd.Parameters.AddWithValue("@id", invoice);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public Customerdetail totalpending(Customerdetail cus)
        {
            decimal total = nettotal(cus);
            decimal paid = getparttotal(cus);

            decimal pending = total - paid;

            Customerdetail customer = new Customerdetail();
            customer.Pending = pending;


            return customer;
        }

        private decimal nettotal(Customerdetail cus)
        {
            String sql = "select sum(total) from wholesale_invoices where customer=@customer";
            int cid = cus.Customer;
            decimal total = 0;

            try
            {
                DBconnection db = new DBconnection();
                db.init();
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@customer", cid);                
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    total = reader.GetDecimal(0);
                }
                
            }
            catch (Exception e)
            {
                total = 0;
            }

            return total;
        }

        private decimal getparttotal(Customerdetail cus)
        {
            int customer = cus.Customer;
            decimal paid = 0;

            String sql = "SELECT sum(wholesale_invoice_payment_steps.paid_partial_amount) from wholesale_invoices inner join wholesale_invoice_payment_steps on wholesale_invoices.id=wholesale_invoice_payment_steps.invoice where wholesale_invoices.customer=@customer";

            try
            {
                DBconnection db = new DBconnection();
                db.init();
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@customer", customer);
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    paid = reader.GetDecimal(0);
                }

            }
            catch (Exception e)
            {
                paid = 0;
            }

            return paid;
        }


        public void addcheque(Customerdetail cheque)
        {
            String chno = cheque.Chno;
            decimal amount = cheque.Patialpayment;
            String sts = cheque.Chstatus;
            MessageBox.Show(sts);
            String sql = "insert into cheques(number,amount,date,status) values(@chno,@amount,now(),@sts)";

            DBconnection db = new DBconnection();

            try
            {

                db.init();
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@chno", chno);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@sts", sts);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("cheque checked");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
