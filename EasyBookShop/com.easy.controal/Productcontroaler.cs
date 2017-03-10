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
    }
}
