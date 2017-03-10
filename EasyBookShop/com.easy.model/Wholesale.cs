using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.com.easy.model
{
    class Wholesale
    {
        private String dis;      
        private String brnd;
        private int qty;
        private Decimal price;
        private String code;
        private Decimal orprice;

        public Decimal Orprice
        {
            get { return orprice; }
            set { orprice = value; }
        }


        public String Code
        {
            get { return code; }
            set { code = value; }
        }

        public String Dis
        {
            get { return dis; }
            set { dis = value; }
        }

        public String Brnd
        {
            get { return brnd; }
            set { brnd = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        

        public Decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
