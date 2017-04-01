using EasyBookShop.com.easy.model;
using EasyBookShop.com.easy.utility;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBookShop.com.easy.controal
{
    class ChequePaymentControal
    {
        public List<String> GetAllBank()
        {
            List<String> Bank_List = new List<string>();
            String sql = "select * from banks";

            DBconnection db = new DBconnection();
            db.init();
            try
            {
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Bank_List.Add(reader.GetString(1));
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return Bank_List;
            
        }

        public ChequePayment getbankid(ChequePayment bank)
        {
            String name = bank.Bank_name;
            
            String sql = "select id from banks where name=@bank";
            DBconnection db = new DBconnection();
            db.init();
            try
            {
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@bank", name);
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    ChequePayment cp=new ChequePayment();
                    int bid=reader.GetInt16(0);
                    cp.Bankid=bid;

                    return cp;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return null;
        }

        public void addcheque(ChequePayment cheque)
        {
            String chno = cheque.Chnumber;
            decimal amount = cheque.Chamount;
            String sts = cheque.Status;
            int bid = cheque.Bankid;
            
            String sql = "insert into cheques(number,amount,date,status,banks_id) values(@chno,@amount,now(),@sts,@bid)";

            DBconnection db = new DBconnection();

            try
            {

                db.init();
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@chno", chno);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@sts", sts);
                cmd.Parameters.AddWithValue("@bid", bid);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("cheque checked");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public void save_invoice(ChequePayment invoice)
        {
            
            try
            {
                DBconnection db = new DBconnection();
                int cus = invoice.Customer;
                int user = invoice.Cashier;
                decimal total = invoice.Total;
                String cuslevel = invoice.Customer_level;
                String method = invoice.Method;
                DateTime today = DateTime.Today;

                db.init();
                String sql = "insert into wholesale_invoices(customer, date,total, customer_level, cashier, method) values(@cus,@date,@total,@cuslevel,@user,@method)";

                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cus", cus);
                cmd.Parameters.AddWithValue("@date", today);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@cuslevel", cuslevel);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@method", method);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void insert_items(ChequePayment items)
        {
            try
            {
                DBconnection db = new DBconnection();

                int invoice = items.Blno;
                int item = items.Item1;
                int qty = items.Qty;
                decimal uprice = items.Uprice;

                db.init();
                MySqlConnection con = db.getConnection();
                String sql = "insert into wholesale_invoice_items(invoice, item, quantity, unit_price) values(@invoice,@item,@qty,@uprice)";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@invoice", invoice);
                cmd.Parameters.AddWithValue("@item", item);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@uprice", uprice);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void AddWIC(ChequePayment cheque)
        {
            int chid = cheque.Chid;
            int blno = cheque.Blno;

            try
            {
                String sql = "insert into wholesale_invoices_cheques(invoice, cheque) values(@invoice,@chid)";

                DBconnection db = new DBconnection();
                db.init();
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@invoice", blno);
                cmd.Parameters.AddWithValue("@chid", chid);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

        }


        public ChequePayment getCheckid()
        {
            ChequePayment cus = new ChequePayment();
            String sql = "select max(id) as last from cheques ";

            try
            {
                DBconnection db = new DBconnection();
                db.init();
                MySqlConnection con = db.getConnection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int chid = reader.GetInt16(0);
                    cus.Chid = chid;
                 
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return cus;
        }


        public void addpaymentstep(ChequePayment cheque)
        {
            int invoice = cheque.Blno;
            
            decimal pp = cheque.Ppamount;
            String Method = cheque.Method;

            DBconnection db = new DBconnection();
            db.init();
            MySqlConnection con = db.getConnection();

            if (Method.Equals("cheque"))
            {
                int chid = cheque.Chid;

                String sql = "insert into wholesale_invoice_payment_steps(invoice, paid_partial_amount, date, method, cheque) values(@invoice,@pp,now(),@method,@cheque)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@invoice", invoice);
                cmd.Parameters.AddWithValue("@pp", pp);
                cmd.Parameters.AddWithValue("@method", Method);
                cmd.Parameters.AddWithValue("@cheque", chid);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
            else
            {
                String sql = "insert into wholesale_invoice_payment_steps(invoice, paid_partial_amount, date, method) values(@invoice,@pp,now(),@method)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@invoice", invoice);
                cmd.Parameters.AddWithValue("@pp", pp);
                cmd.Parameters.AddWithValue("@method", Method);
                

                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }

        }

        public void updateitem(ChequePayment item)
        {
            int qty = item.Qty;
            int rqty = item.Rqty;
            int id = item.Item1;
            int avqty = qty - rqty;
            MessageBox.Show("ID " + id.ToString());
            

            try
            {
                DBconnection db = new DBconnection();
                db.init();
                MySqlConnection con = db.getConnection();
                String sql = "update items set quantity=@qty where id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@qty", avqty);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
