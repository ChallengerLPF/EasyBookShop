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
        public ArrayList findall(){

            ArrayList list = new ArrayList();

            String sql = "select description,category,quantity,wholesale_price from items";
            DBconnection db = new DBconnection();

            Redtxt rdv = new Redtxt();
            String[] data = rdv.redtext();

            db.setConnecton(data[0], data[2], data[3], data[1]);
            MySqlConnection con = db.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            //while (reader.HasRows)
            //{
                //Console.WriteLine("test1");
                while (reader.Read())
                {
                    Wholesale wl = new Wholesale();

                    String dis = (String)reader.GetValue(0);
                    String cat = (String)reader.GetValue(1);
                    int qty = (int)reader.GetValue(2);
                    Decimal price = (Decimal)reader.GetValue(3);

                    wl.Dis = dis;
                    wl.Brnd = cat;
                    wl.Qty = qty;
                    wl.Price = price;

                    list.Add(wl);

                }
                
           // }

            return list;
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
                String cat = (String)reader.GetValue(1);
                int qty = (int)reader.GetValue(2);
                Decimal price = (Decimal)reader.GetValue(3);
                Decimal orprice = (Decimal)reader.GetValue(4);
                int id = (int)reader.GetValue(5);

                wl.Dis = dis;
                wl.Brnd = cat;
                wl.Qty = qty;
                wl.Price = price;
                wl.Orprice = orprice;
                wl.Id = id;

                Console.WriteLine(wl.Dis);

            }
           

            // }

            return wl;
        }


    }
}
