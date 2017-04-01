using EasyBookShop.com.easy.model;
using EasyBookShop.com.easy.utility;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBookShop.com.easy.controal
{
    class Productcontroaler
    {
        public MySqlDataAdapter findall(){

            String sql = "select items.description as Discription,barcode as Barcode,quantity as Quantity ,wholesale_price as Price from items";
            DBconnection db = new DBconnection();

            db.init();
            MySqlConnection con = db.getConnection();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

            

            return da;
        }

        public Wholesale findone(String code)
        {
            
            Wholesale wl = new Wholesale();

            String sql = "select description,category,quantity,wholesale_price,original_price,id from items where barcode=@code";
            DBconnection db = new DBconnection();

            Redtxt rdv = new Redtxt();
            String[] list = rdv.redtext();

            db.setConnecton(list[0], list[2], list[3], list[1]);
            MySqlConnection con = db.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@code",code);
            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();

            //while (reader.HasRows)
            //{
            //Console.WriteLine("test1");
            if (reader.Read())
            {
                

                String dis = (String)reader.GetValue(0);
                int cat = (int)reader.GetValue(1);
                int qty = (int)reader.GetValue(2);
                decimal price = reader.GetDecimal(3);
                decimal orprice = reader.GetDecimal(4);
                int id = (int)reader.GetValue(5);

                wl.Dis = dis;
                wl.Brnd = cat;
                wl.Qty = qty;
                wl.Price = price;
                wl.Orprice = orprice;
                wl.Id = id;



            }
            else
            {
                wl.Dis = "Item not found";
                
            }
           

            // }

            return wl;
        }

        public MySqlDataAdapter search_byIname(String code)
        {

            //ArrayList list = new ArrayList();

            String sql = "select description as Discription,barcode as Barcode,quantity as Quantity ,wholesale_price as Price from items where description like '%" + code + "%' ";
            DBconnection db = new DBconnection();
            
            db.init();
            MySqlConnection con = db.getConnection();
            //MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            //da.Parameters.AddWithValue("@code", "%"+code+"%");

            // }

            return da;
        }

        internal MySqlDataAdapter search_byBarcode(string barcode)
        {
            String sql = "select description as Discription,barcode as Barcode,quantity as Quantity ,wholesale_price as Price from items where barcode like '" + barcode + "%' ";
            DBconnection db = new DBconnection();

            db.init();
            MySqlConnection con = db.getConnection();
            //MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            //da.Parameters.AddWithValue("@code", "%"+code+"%");

            // }

            return da;
        }

        public int getrowcount(String barcode)
        {
            String sql = "select count(id) from items where barcode=@barcode";
            
            int count = 0;
            try
            {
                DBconnection db = new DBconnection();
                db.init();
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    count = reader.GetInt16(0);
                    
                    return count;
                }

                
            }
            catch (Exception e)
            {
                MessageBox.Show("There are no items with this barcode !", "Barcode Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return count;
        }


        public MySqlDataAdapter findmitual(String barcode)
        {
            String sql = "select id,description as Description,barcode as Item_Code,quantity as Quantity,wholesale_price as Price from items where barcode=@code and quantity>0";

            MySqlDataAdapter da = new MySqlDataAdapter();

            try
            {
                DBconnection db = new DBconnection();
                db.init();
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@code", barcode);
                cmd.Prepare();

                
                da.SelectCommand = cmd;
                return da;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return da;
        }


        public Wholesale findoneById(String code)
        {

            Wholesale wl = new Wholesale();

            String sql = "select description,category,quantity,wholesale_price,original_price,id,barcode from items where id=@code";
            DBconnection db = new DBconnection();

            Redtxt rdv = new Redtxt();
            String[] list = rdv.redtext();

            db.setConnecton(list[0], list[2], list[3], list[1]);
            MySqlConnection con = db.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();

            //while (reader.HasRows)
            //{
            //Console.WriteLine("test1");
            if (reader.Read())
            {

                
                String dis = (String)reader.GetValue(0);
                int cat = (int)reader.GetValue(1);
                int qty = (int)reader.GetValue(2);
                decimal price = reader.GetDecimal(3);
                decimal orprice = reader.GetDecimal(4);
                int id = (int)reader.GetValue(5);
                String barcode = reader.GetString(6);

                wl.Dis = dis;
                wl.Brnd = cat;
                wl.Qty = qty;
                wl.Price = price;
                wl.Orprice = orprice;
                wl.Id = id;
                wl.Code = barcode;



            }
            else
            {
                wl.Dis = "Item not found";

            }

            return wl;
        }
    }
}
