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

            String sql = "select customers.id,full_name,level,gender,phone_no from customers where nic=@nic";
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
                String phn = reader.GetString(4);

                cus.Id = id;
                cus.Fname = fname;
                cus.Level = level;
                cus.Gender = gen;
                cus.Phone_no = phn;

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

        public void addcustomer(Customer cus)
        {
            String name = cus.Fname;
            String nic = cus.Nic;
            String tp = cus.Phone_no;
            String gen = cus.Gender;
            String level = cus.Level;

            

            try
            {
                DBconnection db = new DBconnection();
                db.init();

                String sql = "insert into customers(nic, phone_no, full_name, gender, level) values(@nic,@phn,@fname,@gen,@level)";

                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@phn", tp);
                cmd.Parameters.AddWithValue("@fname", name);
                cmd.Parameters.AddWithValue("@gen", gen);
                cmd.Parameters.AddWithValue("@level", level);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void Customer_update(Customer cus)
        {
            try
            {
                String name = cus.Fname;
                String nic = cus.Nic;
                String tp = cus.Phone_no;
                String gen = cus.Gender;
                String level = cus.Level;
                int id = cus.Id;
                MessageBox.Show(level);

                String sql = "update customers set nic=@nic, phone_no=@phn, full_name=@fname, gender=@gen, level=@level where id=@id";

                DBconnection db = new DBconnection();
                db.init();
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@phn", tp);
                cmd.Parameters.AddWithValue("@fname", name);
                cmd.Parameters.AddWithValue("@gen", gen);
                cmd.Parameters.AddWithValue("@level", level);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Success !");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            


        }

        public MySqlDataAdapter findall(String type)
        {
            if (type.Equals("*"))
            {
                try
                {
                    String sql = "select id as ID,full_name as Name, nic as NIC, phone_no as Phone, gender Gender, level as Level from customers";
                    DBconnection db = new DBconnection();
                    db.init();
                    MySqlConnection con = db.getConnection();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

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
                    String sql = "select id as ID,full_name as Name, nic as NIC, phone_no as Phone, gender Gender, level as Level from customers where level in (@type) ";
                    DBconnection db = new DBconnection();
                    db.init();
                    MySqlConnection con = db.getConnection();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

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

        

        
        public void delete_customer(int id)
        {
            try
            {
                String sql = "delete from customers where id=@id";
                DBconnection db = new DBconnection();
                db.init();
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Customer getcustomer(int id)
        {
            Customer cus = new Customer();

            String sql = "select customers.nic,full_name,level,gender,phone_no from customers where id=@id";
            DBconnection db = new DBconnection();

            db.init();
            MySqlConnection con = db.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                String nic = reader.GetString(0);
                String fname = (String)reader.GetValue(1);
                String level = reader.GetString(2);
                String gen = (String)reader.GetValue(3);
                String phn = reader.GetString(4);

                cus.Nic = nic;
                cus.Fname = fname;
                cus.Level = level;
                cus.Gender = gen;
                cus.Phone_no = phn;
                

            }

            return cus;
        }
    }
}
