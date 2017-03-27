using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.com.easy.model
{
    class Invoice_payment_steps
    {

        private int invoice;

        private decimal Patial_payment;
        private String date;

        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Invoice
        {
            get { return invoice; }
            set { invoice = value; }
        }

        public decimal Patial_payment1
        {
            get { return Patial_payment; }
            set { Patial_payment = value; }
        }

    }
}
