using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.com.easy.model
{
    class Login
    {
        private String uname;
        private String pw;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Uname
        {
            get { return uname; }
            set { uname = value; }
        }
        

        public String Pw
        {
            get { return pw; }
            set { pw = value; }
        }


    }
}
