using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.com.easy.utility
{
    class Spliter
    {
        public String[] Split_text(String txt, char[] c)
        {
            String[] ftxt=null;

            for (int i = 0; i < txt.Length; i++)
            {
                ftxt = txt.Split(c);
            }
                

            return ftxt;
        }
    }
}
