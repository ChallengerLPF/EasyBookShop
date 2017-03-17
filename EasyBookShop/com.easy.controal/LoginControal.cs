using EasyBookShop.com.easy.model;
using EasyBookShop.com.easy.utility;
using EasyBookShop.com.easy.view;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBookShop.com.easy.controal
{
    class LoginControal
    {
        public Login logincheck(Login user){

            Login loged = new Login();

            try
            {
                String sql = "select id,username from users where username=@uname and password=@pw";
                DBconnection db = new DBconnection();

                Redtxt rdv = new Redtxt();
                String[] data=rdv.redtext();

                db.setConnecton(data[0], data[2], data[3], data[1]);
                MySqlConnection con = db.getConnection();
                MySqlCommand cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@uname",user.Uname);
                cmd.Parameters.AddWithValue("@pw", user.Pw);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    loged.Id = id;
                    loged.Uname = (String)reader.GetValue(1);
                }
                else
                {
                    MessageBox.Show("User Name or Password incorrect");
                    
                    
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return loged;
        }
    }
}
