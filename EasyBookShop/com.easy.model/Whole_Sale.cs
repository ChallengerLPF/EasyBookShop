using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.com.easy.model
{
    class Whole_Sale
    {
        private int customer;
        private DateTime date;
        private decimal total;
        private int chachier;
        private String method;
        private int check;

        

        public int Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public int Chachier
        {
            get { return chachier; }
            set { chachier = value; }
        }

        public String Method
        {
            get { return method; }
            set { method = value; }
        }

        public int Check
        {
            get { return check; }
            set { check = value; }
        }
    }
}
