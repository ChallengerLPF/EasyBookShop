using EasyBookShop.com.easy.model;
using EasyBookShop.com.easy.utility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.com.easy.controal
{
    class WhalesalePaymentStepControall
    {
        public MySqlDataAdapter getsteps(WholesalePayment_steps invoice){

            int bill=invoice.Invoice;

            String sql = "SELECT wholesale_invoice_payment_steps.date as Paied_Date,paid_partial_amount as Amount,method as Method,cheques.number as Cheque_No from wholesale_invoice_payment_steps left join cheques on wholesale_invoice_payment_steps.cheque=cheques.id where wholesale_invoice_payment_steps.invoice=@invoice order by Paied_Date";

            DBconnection db = new DBconnection();
            db.init();
            MySqlConnection con=db.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@invoice", bill);
            cmd.Prepare();

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            return sda;

        }
        
    }
}
