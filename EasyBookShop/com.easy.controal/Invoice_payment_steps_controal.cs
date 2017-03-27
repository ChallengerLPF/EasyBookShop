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
    class Invoice_payment_steps_controal
    {
        public void insert_step(Invoice_payment_steps invoice)
        {
            int blno = invoice.Invoice;
            decimal payment = invoice.Patial_payment1;

            DBconnection db = new DBconnection();

            try
            {
                db.init();
                MySqlConnection con = db.getConnection();
                String sql = "insert into wholesale_invoice_payment_steps(invoice, paid_partial_amount, date) values(@invoice,@payment,now())";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@invoice", blno);
                cmd.Parameters.AddWithValue("@payment", payment);

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
