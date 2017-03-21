using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBookShop.com.easy.utility
{
    class Redtxt
    {
        public String[] redtext()
        {

            try
            {
                using (StreamReader sr = new StreamReader("dbconfig.txt"))
                {

                    String line = sr.ReadToEnd();
                    char spliter = '/';
                    String[] data = line.Split(spliter);


                    return data;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
