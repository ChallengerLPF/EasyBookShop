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
    }
}
