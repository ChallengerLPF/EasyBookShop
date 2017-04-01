using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.com.easy.model
{
    class Customerdetail
    {
        private int id;
        private int customer;
        private String method;
        private String date;
        private int checkid;
        private decimal patialpayment;
        private int invoice;
        private decimal pending;
        private String ppmethod;
        private String chno;
        private String chstatus;

        public String Chstatus
        {
            get { return chstatus; }
            set { chstatus = value; }
        }

        public String Chno
        {
            get { return chno; }
            set { chno = value; }
        }

        public String Ppmethod
        {
            get { return ppmethod; }
            set { ppmethod = value; }
        }

        public decimal Pending
        {
            get { return pending; }
            set { pending = value; }
        }

        public int Invoice
        {
            get { return invoice; }
            set { invoice = value; }
        }

        public decimal Patialpayment
        {
            get { return patialpayment; }
            set { patialpayment = value; }
        }

        public int Checkid
        {
            get { return checkid; }
            set { checkid = value; }
        }

        public String Date
        {
            get { return date; }
            set { date = value; }
        }
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        private String cashier;

        public String Cashier
        {
            get { return cashier; }
            set { cashier = value; }
        }
        

        public String Method
        {
            get { return method; }
            set { method = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public int Customer
        {
            get { return customer; }
            set { customer = value; }
        }
    }
    
}
