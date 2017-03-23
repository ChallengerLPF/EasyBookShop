using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBookShop.com.easy.utility
{
    class Customer_validate
    {
        public Boolean customer(String cus)
        {

            if (cus.Length > 13)
            {
                int end = cus.Length - 13;

                try
                {
                    int no = int.Parse(cus.Substring(13, end));

                    if (no > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception e)
                {
                    return false;
                }
                
            }

            return false;
        }

        public Boolean validate_text(String text,String value)
        {
            if (!text.Equals(value))
            {
                return true;
            }

            return false;
        }

        public Boolean Qty_validate(String stqty,String qty)
        {
            try
            {
                int sqty = int.Parse(stqty);
                int rqty = int.Parse(qty);

                if (sqty >= rqty)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return false;
        }
    }

}
