using EasyBookShop.com.easy.model;
using EasyBookShop.com.easy.utility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBookShop.com.easy.controal
{
    class Perchuspopup_controaler
    {
        DBconnection db = new DBconnection();
        public Puschespopup setbilno()
        {
            Puschespopup pp=new Puschespopup();
            
            db.init();
            MySqlConnection con = db.getConnection();
            String sql = "select max(id) from wholesale_invoices";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            try
            {
                pp.Id = (int)cmd.ExecuteScalar();
            }
            catch
            {
                pp.Id = 0;
            }


            con.Close();
            return pp;
        }

        public void save_invoice(Puschespopup invoice)
        {
            try
            {
                int cus = invoice.Cus;
                int user = invoice.Cashire;
                decimal total = invoice.Total;
                String cuslevel = invoice.Cuslevel;
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

        public Puschespopup getinvoice_id()
        {
            Puschespopup pp = new Puschespopup();

            try
            {
                db.init();
                MySqlConnection con = db.getConnection();
                String sql = "select max(id) from wholesale_invoice";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                pp.Id = (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return pp;

        }

        public void insert_items(Puschespopup items)
        {
            try
            {
                int invoice = items.Id;
                int item = items.Item;
                int qty = items.Qty;
                decimal uprice = items.Uprice;

                db.init();
                MySqlConnection con = db.getConnection();
                String sql = "insert into wholesale_invoice_items(invoice, item, quantity, unit_price) values(@invoice,@item,@qty,@uprice)";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@invoice", (invoice-1));
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

        internal void update_items(Item it)
        {
            try
            {
                int Id = it.Id;
                int qty = it.Qty;
                int sqty = it.Rqty;
                int newqty = sqty-qty;

               
                db.init();
                MySqlConnection con = db.getConnection();
                String sql = "update items set quantity=@qty where id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@qty", newqty);
                cmd.Parameters.AddWithValue("@id", Id);
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
