using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.com.easy.model
{
    class ChequePayment
    {
        private int bankid;
        private String bank_name;
        private int customer;
        private decimal total;
        private String customer_level;
        private String method;
        private int cashier;
        private String chnumber;
        private decimal chamount;
        private String status;
        private int blno;
        private int item;
        private int qty;
        private decimal uprice;
        private int chid;
        private decimal ppamount;
        private int rqty;

        public int Rqty
        {
            get { return rqty; }
            set { rqty = value; }
        }

        
        public decimal Ppamount
        {
            get { return ppamount; }
            set { ppamount = value; }
        }

        public int Chid
        {
            get { return chid; }
            set { chid = value; }
        }

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

        

        public int Item1
        {
            get { return item; }
            set { item = value; }
        }

        public int Blno
        {
            get { return blno; }
            set { blno = value; }
        }

        public String Bank_name
        {
            get { return bank_name; }
            set { bank_name = value; }
        }


        public String Status
        {
            get { return status; }
            set { status = value; }
        }

        public decimal Chamount
        {
            get { return chamount; }
            set { chamount = value; }
        }

        public String Chnumber
        {
            get { return chnumber; }
            set { chnumber = value; }
        }
        public int Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        

        public String Customer_level
        {
            get { return customer_level; }
            set { customer_level = value; }
        }
        

        public int Cashier
        {
            get { return cashier; }
            set { cashier = value; }
        }
        

        public String Method
        {
            get { return method; }
            set { method = value; }
        }
        public int Bankid
        {
            get { return bankid; }
            set { bankid = value; }
        }

    }
}
