using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.com.easy.model
{
    class Puschespopup
    {
        private int id;
        private int cus;
        private decimal total;
        private String cuslevel;
        private int cashire;
        private String method;

        

        public int Id
        {
            get { return id; }
            set {


                int bno = value;
                Console.Write(bno);
                id = bno+1;
            }
        }

        public int Cus
        {
            get { return cus; }
            set { cus = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public String Cuslevel
        {
            get { return cuslevel; }
            set { cuslevel = value; }
        }

        public int Cashire
        {
            get { return cashire; }
            set { cashire = value; }
        }

        public String Method
        {
            get { return method; }
            set { method = value; }
        }
    }
}
