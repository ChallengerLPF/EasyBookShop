using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace EasyBookShop.com.easy.utility
{
    class DBconnection
    {
        private MySqlConnection con;

        public void setConnecton(String host,String uname,String pw,String pno)
        {
            try
            {
                String Connection = "datasource=" + host + ";port=" + pno + ";username=" + uname + ";password=" + pw + ";database=db_easy_book_shop";
                con = new MySqlConnection(Connection);
                con.Open();
                MessageBox.Show("connection open");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public MySqlConnection getConnection()
        {

            return con;
        }
    }
}
