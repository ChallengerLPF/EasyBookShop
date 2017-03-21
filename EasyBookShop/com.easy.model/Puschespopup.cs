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
        private int item;
        private int qty;
        private decimal uprice;

        public decimal Uprice
        {
            get { return uprice; }
            set { uprice = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public int Item
        {
            get { return item; }
            set { item = value; }
        }

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
