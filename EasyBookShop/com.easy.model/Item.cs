using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.com.easy.model
{
    class Item
    {
        private int id;
        private int qty;
        private int rqty;

        public int Rqty
        {
            get { return rqty; }
            set { rqty = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }


    }
}
