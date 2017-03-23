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
    class Customer_controal
    {
        public Customer getuser(String nic)
        {
            Customer cus=new Customer();

            String sql = "select customers.id,full_name,level,gender from customers where nic=@nic";
            DBconnection db = new DBconnection();

            db.init();
            MySqlConnection con = db.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
               
                int id = (int)reader.GetValue(0);
                String fname = (String)reader.GetValue(1);
                String level = (String)reader.GetValue(2);
                String gen = (String)reader.GetValue(3);

                cus.Id = id;
                cus.Fname = fname;
                cus.Level = level;
                cus.Gender = gen;

            }
           
            return cus;
        }

        public Customer getpending(String id)
        {
            Customer cus = new Customer();

            String sql = "select sum(total) as total from wholesale_invoices where customer=@id and method='credit' ";

            DBconnection db = new DBconnection();

            db.init();
            MySqlConnection con = db.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                try
                {
                    decimal total = reader.GetDecimal(0);

                    cus.Pendings = total;

                }
                catch (Exception e)
                {
                    cus.Pendings = 0;
                }
                
            }

            return cus;

        }
    }
}
